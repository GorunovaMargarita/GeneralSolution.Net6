using NUnit.Framework;
using QaseIOAPITests.ApiServiceStep;
using QaseIOAPITests.BusinessObject;
using QaseIOAPITests.BusinessObject.Model;
using QaseIOAPITests.BusinessObject.Services;

namespace QaseIOAPITests
{
    public class ProjectTests : BaseAPITest
    {
        [Test]
        public void GETProjectByCode_ExistingCode_OK()
        {
            var projectMustBe = ProjectHandler.existingProject;

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
                Code = System.DateTime.Now.ToString("fffffff"),
                Access = "none"
            };

            var projectResponse = apiProjectSteps.CreateProject(projectModel);

            ProjectHandler.AddProjectCodeForDelete(projectModel.Code);

            Assert.That(projectModel.Code, Is.EqualTo(projectResponse.Result.Code));
            Assert.IsTrue(projectResponse.Status);
        }

        [Test]
        public void POSTCreateProject_CodeNotUnic_BadRequest()
        {
            var project = new CreateProjectModel()
            {
                Title = "Test",
                Code = ProjectHandler.existingProject.Code,
                Access = "none"
            };

            var response = apiProjectSteps.CreateProject(project);

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
            var project = ProjectHandler.CreateAndGetRandomProject();

            var deleteResponse = apiProjectSteps.DeleteProjectByCode(project.Code);
            Assert.IsTrue(deleteResponse.Status);

            var getResponse = apiProjectSteps.GetProjectByCode(project.Code);
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

        [TearDown]
        public void CleanProjectData()
        {
            ProjectHandler.DeleteProjects();
        }
    }
}
