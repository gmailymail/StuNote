using DevExpress.XtraBars.Navigation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StuNote.Domain.Services;
using System;
using System.Threading.Tasks;

namespace StuNote.Student
{
    public partial class FMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private bool _loaded = false;
        private readonly ICourseService _courseService;
        private readonly string _appName;

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
        }
    }
}
