using DevExpress.XtraBars.Navigation;
using DevExpress.XtraRichEdit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StuNote.Domain;
using StuNote.Domain.Btos.Course;
using StuNote.Domain.Services;
using System;
using System.Threading.Tasks;
using NAudio.Wave;
using Microsoft.AspNet.SignalR.Client;
using StuNote.Domain.Btos.Survey;

namespace StuNote.Student
{
    public partial class FMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private bool _loaded = false;
        private readonly ILogger<FMain> _logger;
        private readonly ICourseService _courseService;
        private readonly IStorageLocatorFactoryService _storageFactory;
        private readonly ISurveyResponseService _surveyResponse;
        private readonly FormSurveyAnswer _fSurvAnswer;
        private readonly string _appName;
        private bool _saving = false;
        AccordionControlElement element;

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

        public FMain(ILogger<FMain> logger,
                     ICourseService courseService,
                     IConfiguration configuration,
                     IStorageLocatorFactoryService storageFactory,
                     ISurveyResponseService surveyResponse,
                     FormSurveyAnswer fSurvAnswer,
                     IQuestionResponseService questionResponse)
        {
            InitializeComponent();
            _logger = logger;
            _courseService = courseService;
            _storageFactory = storageFactory;
            _surveyResponse = surveyResponse;
            _fSurvAnswer = fSurvAnswer;
            _appName = configuration.GetValue<string>("Title");
            //implement Audio feature
            //initAudio();
            _receivedSurvey = HandleReceivedSurvey;
            richEditControl1.ContentChanged += RichEditControl1_ContentChanged;
            _surveyResponse.SurveyReceived += surveyReceived;
            questionResponse.QuestionReceived += async (s, e) =>
            {
                await questionResponse.SendAsync(new Domain.Btos.Question.QuestionResponseBto
                {
                    StudentId = "email.com",
                    SelectedAnswer = 1
                }) ;
            };
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
                    richEditControl1.LoadDocument(bytes, DocumentFormat.OpenXml);
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
                var notes = richEditControl1.DocmBytes;
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
        #region Audio Recognition
        private void initAudio()
        //private void StartBtn_Click(object sender, EventArgs e)
        {
            if (waveIn != null)
                return;

            // create wave input from mic
            waveIn = new WaveIn(this.Handle);
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
                waveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
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

        #endregion Helper Methods
    }
}