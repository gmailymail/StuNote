using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.UI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StuNote.Domain.Services;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuNote.Student
{
    public partial class FMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private bool _loaded = false;
        private readonly ICourseService _courseService;
        private readonly string _appName;
        private string _selectedFileName = "", _selectedSession = "";

        public FMain(
            ILogger<FMain> logger, 
            ICourseService courseService,
            IConfiguration configuration)
        {
            InitializeComponent();
            logger.LogInformation("This line is demonstrate Service Container is working.");
            _courseService = courseService;
            _appName = configuration.GetValue<string>("Title");
            
        }
        
        private void accordionControlElement6_Click(object sender, EventArgs e)
        {

        }

        //Load Courses into Left Navigation Menu
        private async void FMain_Load(object sender, EventArgs e)
        {
            var program = await _courseService.GetEnrolledProgramAsync();
            AccordionControlElement progAcc = new() { Text = program.Name };
            accMyCourses.Elements.Add(progAcc);
            if (_loaded is false)
            {
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
                            AccordionControlElement accSess = new() {Style=ElementStyle.Item, Text = $"Session {ss.Number} - {ss.Date.ToShortDateString()}" };
                            accMod.Elements.Add(accSess);
                        }
                    }
                }
            }
            _loaded = true;
        }

        private void NavigationMenu_ElementClick(object sender, ElementClickEventArgs e)
        {
            AccordionControlElement element = e.Element as AccordionControlElement;
            if (element is not null && element.Style==ElementStyle.Item)
            {
                Text = $"{_appName} - {element.Text}";
            }
            if (element is not null && element.Text.StartsWith("Session"))
            {
                _selectedSession = element.Text.Trim();
                OpenFileUsingDialog();
            }
        }

        private void OpenFileUsingDialog()
        {
            try {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "doc files (*.docx)|*.docx|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedFileName = openFileDialog.SafeFileName.Trim();
                    richEditControl1.LoadDocument(openFileDialog.FileName.Trim());
                }
                else
                {
                    XtraMessageBox.Show("Please select a file to load.", "Information", MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            { 
            }
        }

        private void barButtonSaveItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            #region Create Temp Folder for Application
            //string _tempFolder = ConfigurationManager.AppSettings["AppTempFolder"]; 
            string _tempFolder = "TempStuNote";
            string tempDirectoryPath = Path.Combine(Path.GetTempPath(), _tempFolder);
            if (!Directory.Exists(tempDirectoryPath))
            {
                Directory.CreateDirectory(tempDirectoryPath);
            }
            #endregion
            #region remove Special characters in SessionName
            _selectedSession = Regex.Replace(_selectedSession, @"\s+", "");
            _selectedSession = Regex.Replace(_selectedSession, @"/", "_");
            #endregion
            #region Create Temp Folder for Session under App folder
            string sessionTempFolder = Path.Combine(tempDirectoryPath, _selectedSession);
            if (!Directory.Exists(sessionTempFolder))
            {
                Directory.CreateDirectory(sessionTempFolder);
            }
            #endregion

            if (!string.IsNullOrEmpty(_selectedFileName)) //TODO : Check is there file loaded to richEditControl1
            {
                string completeSavePath = Path.Combine(sessionTempFolder, _selectedFileName); //Generate complete path
                richEditControl1.SaveDocument(completeSavePath, DocumentFormat.OpenXml); //Save File in temp Folder

                XtraMessageBox.Show("Save Path : " + completeSavePath, "Information", MessageBoxButtons.OK); //To remove
            }
            else {
                XtraMessageBox.Show("_selectedFileName cannot be empty", "Information", MessageBoxButtons.OK); //To remove
            }
        }
    }
}
