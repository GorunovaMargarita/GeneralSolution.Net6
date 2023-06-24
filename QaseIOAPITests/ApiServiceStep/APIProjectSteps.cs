using Newtonsoft.Json;
using NUnit.Framework;
using QaseIOAPITests.BusinessObject.Model;
using QaseIOAPITests.BusinessObject.Services;
using QaseIOAPITests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QaseIOAPITests.ApiServiceStep
{
    public class ApiProjectSteps : ProjectService
    {
        public new CommonResultResponse<Project> GetProjectByCode(string code)
        {
            var response = base.GetProjectByCode(code);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK) || response.StatusCode.Equals(HttpStatusCode.NotFound));
            Assert.IsNotNull(response.Content);

            return JsonConvert.DeserializeObject<CommonResultResponse<Project>>(response.Content);
        }

        public new CommonResultResponse<Project> CreateProject(CreateProjectModel project)
        {
            var response = base.CreateProject(project);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK) || response.StatusCode.Equals(HttpStatusCode.BadRequest));
            Assert.IsNotNull(response.Content);

            return JsonConvert.DeserializeObject<CommonResultResponse<Project>>(response.Content);
        }

        public new CommonResultResponse<AllProjectResponse> GetAllProjects(int limit, int offset)
        {
            var response = base.GetAllProjects(limit, offset);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK) || response.StatusCode.Equals(HttpStatusCode.NotFound));
            Assert.IsNotNull(response.Content);

            return JsonConvert.DeserializeObject<CommonResultResponse<AllProjectResponse>>(response.Content);
        }

        public new CommonResultResponse DeleteProjectByCode(string code)
        {
            var response = base.DeleteProjectByCode(code);
            Assert.IsTrue(response.StatusCode.Equals(HttpStatusCode.OK) || response.StatusCode.Equals(HttpStatusCode.NotFound));
            Assert.IsNotNull(response.Content);

            return JsonConvert.DeserializeObject<CommonResultResponse>(response.Content);
        }
    }
}
