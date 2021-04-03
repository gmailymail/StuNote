using DevExpress.XtraBars.Navigation;
using DevExpress.XtraRichEdit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StuNote.Domain;
using StuNote.Domain.Btos.Course;
using StuNote.Domain.Services;
using System;
using System.Threading.Tasks;

namespace StuNote.Student
{
    public partial class FMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private bool _loaded = false;
        private readonly ILogger<FMain> _logger;
        private readonly ICourseService _courseService;
        private readonly IStorageLocatorFactoryService _storageFactory;
        private readonly string _appName;
        private bool _saving=false;
        AccordionControlElement element;

        public FMain(
            ILogger<FMain> logger, 
            ICourseService courseService,
            IConfiguration configuration,
            IStorageLocatorFactoryService storageFactory)
        {
            InitializeComponent();
            _logger = logger;
            _courseService = courseService;
            _storageFactory = storageFactory;
            _appName = configuration.GetValue<string>("Title");
            richEditControl1.ContentChanged += RichEditControl1_ContentChanged;        
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

        #endregion Helper Methods
    }
}