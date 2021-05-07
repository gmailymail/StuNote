using DevExpress.XtraBars.Navigation;
using DevExpress.XtraRichEdit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NAudio.Wave;
using StuNote.Domain;
using StuNote.Domain.Btos.Course;
using StuNote.Domain.Btos.Infrastructure;
using StuNote.Domain.Btos.Question;
using StuNote.Domain.Btos.Survey;
using StuNote.Domain.Services;
using StuNote.Domain.Services.Infrastructure;
using StuNote.Student.UIControl;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;

namespace StuNote.Student
{
    public partial class FMain1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private bool _loaded = false;
        private readonly ILogger<FMain1> _logger;
        private readonly ICourseService _courseService;
        private readonly IStorageLocatorFactoryService _storageFactory;
        private readonly ISurveyResponseService _surveyResponse;
        private readonly IQuestionResponseService _questionResponse;
        private readonly FormSurveyAnswer _fSurvAnswer;
        private readonly FormQuestionAnswer _fQuestAnswer;
        private readonly IServiceProvider _services;
        private readonly IScreenSelectorService _screenSelectorService;
        private readonly ICaptureScreenService _captureScreenService;
        private readonly IImageToTextService _imageToText;
        private readonly string _appName;
        private bool _saving = false;
        AccordionControlElement element;
        private WindowSelectorBto SelectedLectureWindow;
        /// <summary>
        /// Required instances for Mic capture.
        /// </summary>
        private WaveIn waveIn = null;
        private BufferedWaveProvider waveProvider = null;
        private WaveOut waveOut = null;

        /// <summary>
        /// SignalR receives its messages in a separate thread. Therefore,
        /// A delegate is necessary to update UI thread.
        /// </summary>
        /// <param name="survey"></param>
        private delegate void DelReceivedSurvey(SurveyRequestBto survey);
        /// <summary>
        /// To use delegate an instance must be created.
        /// </summary>
        DelReceivedSurvey _receivedSurvey;

        private delegate void DelReceivedQuestion(QuestionRequestBto question);
        DelReceivedQuestion _receivedQuestion;

        public FMain1(ILogger<FMain1> logger,
                     ICourseService courseService,
                     IConfiguration configuration,
                     IStorageLocatorFactoryService storageFactory,
                     ISurveyResponseService surveyResponse,
                     FormSurveyAnswer fSurvAnswer,
                     FormQuestionAnswer fQuestAnswer,
                     IQuestionResponseService questionResponse,
                     IServiceProvider services,
                     IScreenSelectorService screenSelectorService,
                     ICaptureScreenService captureScreenService,
                     IImageToTextService imageToText)
        {

            InitializeComponent();
            _logger = logger;
            _courseService = courseService;
            _storageFactory = storageFactory;
            _surveyResponse = surveyResponse;
            _fSurvAnswer = fSurvAnswer;
            _fQuestAnswer = fQuestAnswer;
            _services = services;
            _screenSelectorService = screenSelectorService;
            _captureScreenService = captureScreenService;
            _imageToText = imageToText;
            _appName = configuration.GetValue<string>("Title");
            _questionResponse = questionResponse;
            //implement Audio feature
            //initAudio();
            _receivedSurvey = HandleReceivedSurvey;
            _receivedQuestion = HandleReceivedQuestion;
            richEditControl1.ContentChanged += RichEditControl1_ContentChanged;
            _surveyResponse.SurveyReceived += surveyReceived;
            _questionResponse.QuestionReceived += questionReceived;
            //questionResponse.QuestionReceived += async (s, e) =>
            //{
            //    await questionResponse.SendAsync(new Domain.Btos.Question.QuestionResponseBto
            //    {
            //        StudentId = Program.Username,//"email.com",
            //        SelectedAnswer = 1
            //    });
            //};
            //screenSelectorService.OnSelectedScreenChanged += (s, e) =>
            //{
            //    SelectedLectureWindow = e;
            //    initAudio();
            //};
        }

        private void questionReceived(object sender, QuestionRequestBto e)
        {
            // _logger.LogInformation($"Received a Survey : {e.Question}");
             if (InvokeRequired)
              Invoke(_receivedQuestion, e);
        }

        /// <summary>
        /// This event is fired everytime a survey is received from the server.
        /// Handle appropriately. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">instance of SurveyRequestBto</param>
        private void surveyReceived(object sender, SurveyRequestBto e)
        {
            _logger.LogInformation($"Received a Survey : {e.Question}");
            if (InvokeRequired)
                Invoke(_receivedSurvey, e);
        }

        //Handle Save everytime there is a change
        private async void RichEditControl1_ContentChanged(object sender, EventArgs e)
        {
            try
            {
                //Save function must not be called when the save is in progress.
                if (!_saving)
                {
                    _saving = true;
                    await SaveNotes(element);
                    _saving = false;
                }
            }
            catch (Exception)
            {
                _saving = false;
            }
        }

        //Load Courses into Left Navigation Menu
        private async void FMain_Load(object sender, EventArgs e)
        {
            var program = await _courseService.GetEnrolledProgramAsync();
            AccordionControlElement progAcc = new() { Text = program.Name };
            accMyCourses.Elements.Add(progAcc);
            if (_loaded is false)
                foreach (var s in program.Semesters)
                {
                    AccordionControlElement accSem = new() { Text = s.Name };
                    progAcc.Elements.Add(accSem);
                    foreach (var m in s.Modules)
                    {
                        AccordionControlElement accMod = new() { Text = m.Name };
                        accSem.Elements.Add(accMod);
                        foreach (var ss in m.Sessions)
                        {
                            //This is a dirty trick. Traditionally Session.ModuleId is loaded during Load Data Logic.
                            ss.ModuleId = m.Id;
                            AccordionControlElement accSess = new()
                            {
                                Tag = ss,
                                Style = ElementStyle.Item,
                                Text = $"Session {ss.Number} - {ss.Date.ToShortDateString()}"
                            };
                            accMod.Elements.Add(accSess);
                        }
                    }
                }
            _loaded = true;
        }

        //Handle Open Notes.
        private async void NavigationMenu_ElementClick(object sender, ElementClickEventArgs e)
        {
            try
            {
                element = e.Element;

                //Do not perform anything when this condition is met.
                if (element is null || element.Style == ElementStyle.Group)
                    return;

                //Update MainWindow Caption to reflect the selected Session.
                Text = $"{_appName} - {element.Text}";

                //Get the Local File Storage service using IStorageLocatorFactoryService
                var fileStorage = _storageFactory.GetStorageService(StorageType.LocalFile);

                //Get the Session stored in element.Tag
                //element.Tag is updated when sessions are added to the menu
                var sessionBto = element.Tag as SessionBto;

                //Load data from the file.
                var bytes = await fileStorage.OpenNotes(sessionBto);                

                //There is no file stored related to this session.
                if (bytes is null)
                {
                    richEditControl1.CreateNewDocument(false);
                    var position = richEditControl1.Document.CaretPosition;
                    richEditControl1.Document.InsertText(position, element.Text);
                }
                else
                {
                    using Stream stream = new MemoryStream(bytes);
                    richEditControl1.LoadDocument(stream, DocumentFormat.OpenXml);
                }                    
            }
            catch (Exception ex)
            {
                //Handle errors in an intuitive way. Perhaps, updating a Statusbar or some alertbox.
                //But for our project purposes, we will Log Error
                _logger.LogError(ex, "Error while Loading notes");
            }
        }

        #region Helper Methods
        private async Task SaveNotes(AccordionControlElement element)
        {
            try
            {
                //Nothing happens when these conditionas are met.
                if (element is null || element.Style == ElementStyle.Group)
                    return;

                //DocmBytes will the content of the TextBox in OpenXML format
                var notes = richEditControl1.DocBytes;
                //Get the Local File Storage service using IStorageLocatorFactoryService
                var fileStorage = _storageFactory.GetStorageService(StorageType.LocalFile);
                //SessionBto is stored in element.Tag
                var sessionBto = element.Tag as SessionBto;

                //Call SaveNotes
                await fileStorage.SaveNotes(sessionBto, notes);
            }
            catch (Exception ex)
            {
                //Handle errors in an intuitive way. Perhaps, updating a Statusbar or some alertbox.
                //But for our project purposes, we will Log Error
                _logger.LogError(ex, "Error while saving notes");
            }
        }

        /// <summary>
        /// This method is called to handle everytime a survey is received.
        /// </summary>
        /// <param name="survey"></param>
        private void HandleReceivedSurvey(SurveyRequestBto survey)
        {
            if (_fSurvAnswer.Visible is false)
                _fSurvAnswer.ShowDialog(this);
        }

        private void HandleReceivedQuestion(QuestionRequestBto survey)
        {
            if (_fQuestAnswer.Visible is false)
                _fQuestAnswer.ShowDialog(this);
        }


        #region Audio Recognition
        private void initAudio()
        //private void StartBtn_Click(object sender, EventArgs e)
        {
            if (waveIn != null)
                return;

            // create wave input from mic
            waveIn = new WaveIn(SelectedLectureWindow.HandleWindow);
            waveIn.BufferMilliseconds = 25;
            //waveIn.RecordingStopped += waveIn_RecordingStopped;
            waveIn.DataAvailable += waveIn_DataAvailable;

            // create wave provider
            waveProvider = new BufferedWaveProvider(waveIn.WaveFormat);

            // create wave output to speakers
            waveOut = new WaveOut();
            waveOut.DesiredLatency = 100;
            waveOut.Init(waveProvider);
            //waveOut.PlaybackStopped += wavePlayer_PlaybackStopped;

            // start recording and playback
            waveIn.StartRecording();
            waveOut.Play();
        }

        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            // add received data to waveProvider buffer
            if (waveProvider != null)
                _logger.LogInformation($"Audio is being monitored on {DateTime.Now}");
            //waveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            if (waveIn != null)
                waveIn.StopRecording();
        }

        void waveIn_RecordingStopped(object sender, StoppedEventArgs e)
        {
            // stop playback
            if (waveOut != null)
                waveOut.Stop();

            // dispose of wave input
            if (waveIn != null)
            {
                waveIn.Dispose();
                waveIn = null;
            }

            // drop wave provider
            waveProvider = null;
        }

        void wavePlayer_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            // stop recording
            if (waveIn != null)
                waveIn.StopRecording();

            // dispose of wave output
            if (waveOut != null)
            {
                waveOut.Dispose();
                waveOut = null;
            }
        }
        #endregion Audio Recognition

        private async Task ShowWindowSelector()
        {
            var formWindowSelector = _services.GetRequiredService<FormWindowSelector>();
            formWindowSelector.Show();
            await formWindowSelector.LoadOpenWindowsAsync();
        }

        private Image CaptureScreen()
        {
            var image = _captureScreenService.CaptureScreen(SelectedLectureWindow.HandleWindow);
            return image;
        }

        #endregion Helper Methods

        private async void ButtonScreenShot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            await ShowWindowSelector();
        }

        private async void buttonCaptureScreenShot_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (SelectedLectureWindow is null)
                await ShowWindowSelector();
            else
            {
                var image = CaptureScreen();
                var pos = richEditControl1.Document.CaretPosition;
                richEditControl1.Document.Images.Insert(pos, image);
            }
        }

        private async void buttonCaptureText_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            richEditControl1.Document.ContentChanged -= RichEditControl1_ContentChanged;
            var image = CaptureScreen();
            var text = _imageToText.ReadText(image);
            var pos = richEditControl1.Document.CaretPosition;
            richEditControl1.Document.Images.Insert(pos, image);
            pos = richEditControl1.Document.CaretPosition;
            richEditControl1.Document.InsertText(pos, text);
            await SaveNotes(element);
            richEditControl1.Document.ContentChanged += RichEditControl1_ContentChanged;
        }
    }
}
