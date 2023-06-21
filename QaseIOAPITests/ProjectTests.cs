using NUnit.Framework;
using QaseIOAPITests.ApiServiceStep;
using QaseIOAPITests.BusinessObject;
using QaseIOAPITests.BusinessObject.Model;
using QaseIOAPITests.BusinessObject.Services;

namespace QaseIOAPITests
{
    public class ProjectTests : BaseAPITest
    {
        protected ProjectService projectService;
        protected ApiProjectSteps apiProjectSteps;

        [OneTimeSetUp]
        public void InitialService()
        {
            projectService = new ProjectService();
            apiProjectSteps = new ApiProjectSteps();
        }

        [Test]
        public void GETProjectByCode_ExistingCode_OK()
        {
            var projectMustBe = new Project
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

            var project = apiProjectSteps.GetProjectByCode(projectMustBe.Code).Result;

            Assert.That(project, Is.EqualTo(projectMustBe));
        }

        [Test]
        public void GETProjectByCode_NotExistingProjectCode_NotFound()
        {
            var projectCode = "Unknown";

            var response = apiProjectSteps.GetProjectByCode(projectCode);

            Assert.IsFalse(response.Status);
            Assert.That(response.ErrorMessage, Is.EqualTo(MessageContainer.NotFoundError("Project")));
        }

        [Test]
        public void POSTCreateProject_OnlyRequiredAttributes_OK()
        {
            var projectModel = new CreateProjectModel()
            {
                Title = "Test",
                Code = System.DateTime.Now.ToString("fffff"),
                Access = "none"
            };

            var projectResponse = apiProjectSteps.CreateProject(projectModel);

            Assert.That(projectModel.Code, Is.EqualTo(projectResponse.Result.Code));
            Assert.IsTrue(projectResponse.Status);
        }

        [Test]
        public void POSTCreateProject_CodeNotUnic_BadRequest()
        {
            var projectModel = new CreateProjectModel()
            {
                Title = "Test",
                Code = "ANP",
                Access = "none"
            };

            var response = apiProjectSteps.CreateProject(projectModel);

            Assert.IsFalse(response.Status);
            Assert.That(response.ErrorMessage, Is.EqualTo(MessageContainer.DataInvalidError));
            Assert.That(response.ErrorFields.First(e => e.Field.Equals("project")).Error, Does.Contain(MessageContainer.ProjectCodeNotUnique));
        }

        [TestCase(5, 0)]
        [TestCase(5, 1)]
        [TestCase(10, 0)]
        [TestCase(10, 5)]
        [TestCase(10, 10)]
        public void GETAllProjects_OK(int limit, int offset)
        {
            var response = apiProjectSteps.GetAllProjects(limit, offset);

            Assert.IsTrue(response.Status);

            if(limit + offset <= response.Result.Total)
            {
                Assert.IsTrue(response.Result.Count == limit);
                Assert.IsTrue(response.Result.Entities.Count == limit);
            }
            else if (offset + limit > response.Result.Total && offset < response.Result.Total)
            {
                Assert.IsTrue(response.Result.Count == response.Result.Total - offset);
                Assert.IsTrue(response.Result.Entities.Count == response.Result.Total - offset);
            }
            else
            {
                Assert.IsTrue(response.Result.Count == 0);
                Assert.IsTrue(response.Result.Entities.Count == 0);
            }
        }

        [Test]
        public void DELETEProject_ExistingProjectCode_OK()
        {
            var projectModel = new CreateProjectModel()
            {
                Title = "Test",
                Code = System.DateTime.Now.ToString("fffff"),
                Access = "none"
            };

            apiProjectSteps.CreateProject(projectModel);

            var deleteResponse = apiProjectSteps.DeleteProjectByCode(projectModel.Code);
            Assert.IsTrue(deleteResponse.Status);

            var getResponse = apiProjectSteps.GetProjectByCode(projectModel.Code);
            Assert.IsFalse(getResponse.Status);
            Assert.That(getResponse.ErrorMessage, Is.EqualTo(MessageContainer.NotFoundError("Project")));
        }

        [Test]
        public void DELETEProjectByCode_NotExistingProjectCode_NotFound()
        {
            var projectCode = "Unknown";

            var response = apiProjectSteps.DeleteProjectByCode(projectCode);

            Assert.IsFalse(response.Status);
            Assert.That(response.ErrorMessage, Is.EqualTo(MessageContainer.NotFoundError("Project")));
        }
    }
}
