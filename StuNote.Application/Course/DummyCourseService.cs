using StuNote.Domain.Btos.Course;
using StuNote.Domain.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StuNote.Logic.Course
{
    public class DummyCourseService : ICourseService
    {
        private readonly IEnumerable<ProgramBto> programs;
        public DummyCourseService()
        {
            programs = new List<ProgramBto>()
            {
                //MSC IT Program
                //Second test goes here
                 new()
                 {
                     Id=100, Name="MSC IT", Number="P001",
                      Semesters=new List<SemesterBto>()
                      {
                          //Semester 01
                           new()
                           {
                                Id=200, Number="S001", Name="Semester 01",
                                 Modules=new List<ModuleBto>()
                                 {
                                     //Information Security Management
                                     new()
                                     {
                                          Id=300, Name="Information Security Management", Number="CIS-001",
                                          Sessions=new List<SessionBto>
                                          {
                                               new()
                                               {
                                                    Id=400, Number="01", Date=new(2020,12,06)
                                               },
                                              new()
                                               {
                                                    Id=401, Number="02", Date=new(2020,12,13)
                                               },
                                              new()
                                               {
                                                    Id=402, Number="03", Date=new(2021,01,02)
                                               },
                                               new()
                                               {
                                                    Id=403, Number="04", Date=new(2021,01,09)
                                               },
                                                new()
                                               {
                                                    Id=404, Number="05", Date=new(2021,01,09)
                                               },
                                                 new()
                                               {
                                                    Id=405, Number="06", Date=new(2021,01,16)
                                               },
                                                new()
                                               {
                                                    Id=406, Number="07", Date=new(2021,01,16)
                                               },
                                                 new()
                                               {
                                                    Id=407, Number="08", Date=new(2021,01,30)
                                               },
                                                  new()
                                               {
                                                    Id=408, Number="09", Date=new(2021,01,30)
                                               },
                                          }
                                     },
                                     //Technology Project Management
                                     new()
                                     {
                                          Id=301, Name="Technology Project Management", Number="CIS-002",
                                          Sessions=new List<SessionBto>
                                          {
                                               new()
                                               {
                                                    Id=409, Number="01", Date=new(2021,02,06)
                                               },
                                              new()
                                               {
                                                    Id=410, Number="02", Date=new(2021,02,13)
                                               },
                                              new()
                                               {
                                                    Id=411, Number="03", Date=new(2021,02,20)
                                               },
                                               new()
                                               {
                                                    Id=412, Number="04", Date=new(2021,02,27)
                                               },
                                                new()
                                               {
                                                    Id=413, Number="05", Date=new(2021,03,06)
                                               },
                                                 new()
                                               {
                                                    Id=414, Number="06", Date=new(2021,03,13)
                                               },
                                                new()
                                               {
                                                    Id=415, Number="07", Date=new(2021,03,20)
                                               }
                                          }
                                     },
                                     //Team Software Development
                                     new()
                                     {
                                          Id=302, Name="Team Software Development", Number="CIS-003",
                                          Sessions=new List<SessionBto>
                                          {
                                               new()
                                               {
                                                    Id=416, Number="01", Date=new(2021,02,06)
                                               },
                                              new()
                                               {
                                                    Id=417, Number="02", Date=new(2021,02,13)
                                               },
                                              new()
                                               {
                                                    Id=418, Number="03", Date=new(2021,02,20)
                                               },
                                               new()
                                               {
                                                    Id=419, Number="04", Date=new(2021,02,27)
                                               },
                                                new()
                                               {
                                                    Id=420, Number="05", Date=new(2021,03,06)
                                               },
                                                 new()
                                               {
                                                    Id=421, Number="06", Date=new(2021,03,13)
                                               },
                                                new()
                                               {
                                                    Id=422, Number="07", Date=new(2021,03,20)
                                               }
                                          }
                                     }
                                 }
                           },
                           //Semester 02
                           new()
                           {
                                Id=201, Name="Semester 02", Number="S002",
                                Modules=new List<ModuleBto>()
                                {
                                    //End User Computing  Risk Management
                                    new()
                                    {
                                       Id=303, Name="End User Computing  Risk Management", Number="CIS-004",
                                    },
                                    //Programming for Data Analysis
                                    new()
                                    {
                                       Id=304, Name="Programming for Data Analysis", Number="CIS-005",
                                    },
                                    //Geospatial Analysis
                                    new()
                                    {
                                       Id=305, Name="Geospatial Analysis", Number="CIS-006",
                                    },
                                    //Research Methods for Technology Dissertations
                                    new()
                                    {
                                       Id=306, Name="Research Methods for Technology Dissertations", Number="CIS-007",
                                    }
                                }
                           },
                           //Semester 03
                           new()
                           {
                                 Id=202, Name="Semester 03", Number="S003",
                                  Modules=new List<ModuleBto>
                                  {
                                      //Technology Dissertation
                                       new()
                                       {
                                           Id=307, Number="CIS008", Name="Technology Dissertation",
                                       }
                                  }
                           }
                      }
                 }
            };
        }

        public async Task<ProgramBto> GetEnrolledProgramAsync()
        {
            await Task.CompletedTask;
            return programs.FirstOrDefault();
        }

        public async Task<IEnumerable<SessionBto>> GetSessionsAsync(SessionFilterBto sessionFilter = null)
        {
            List<SessionBto> sessions = new();
            foreach (var p in programs)
                foreach (var s in p.Semesters)
                    foreach (var m in s.Modules)
                        sessions.AddRange(m.Sessions);

            await Task.CompletedTask;

            return sessions;
        }
    }
}
