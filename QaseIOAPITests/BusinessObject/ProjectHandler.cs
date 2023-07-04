using QaseIOAPITests.ApiServiceStep;
using QaseIOAPITests.BusinessObject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseIOAPITests.BusinessObject
{
    public class ProjectHandler
    {
        public static List<string> projectCodes = new List<string>();
        public static Project existingProject = new Project
        {
            Code = "ANP",
            Title = "AQA1 new pro",
            Counts = new Counts
            {
                Cases = 1,
                Suites = 0,
                Milestones = 0
            }
        };

        public static void AddProjectCodeForDelete(string code)
        {
            projectCodes.Add(code);
        }

        public static void DeleteProjects()
        {
            var apiProjectSteps = new ApiProjectSteps();
            foreach (var projectCode in  projectCodes)
            {
                apiProjectSteps.DeleteProjectByCode(projectCode); 
            }
        }

        /// <summary>
        /// Create and get project with random attributes
        /// </summary>
        /// <returns>created project</returns>
        public static CreateProjectModel CreateAndGetRandomProject()
        {
            var apiProjectSteps = new ApiProjectSteps();
            var project = new CreateProjectModel()
            {
                Title = "Test",
                Code = System.DateTime.Now.ToString("fffff"),
                Access = "none"
            };

            apiProjectSteps.CreateProject(project);
            return project;
        }
    }
}
