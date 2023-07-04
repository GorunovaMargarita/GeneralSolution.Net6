using QaseIOAPITests.BusinessObject.Model;
using QaseIOAPITests.Core;
using QaseIOAPITests.Configuration;
using QaseIOAPITests.Models;
using RestSharp;
using NLog;
using FluentAssertions.Equivalency;

namespace QaseIOAPITests.BusinessObject.Services
{
    public class ProjectService : BaseService
    {
        public string ProjectEndpoint = "/project";
        public string ProjectByCodeEndpoint = "/project/{code}";
        public string GetAllProjectsEndpoint = "/project?limit={limit}&offset={offset}";

        public ProjectService() : base(Configurator.API.BaseUrl)
        {
            apiClient.AddAuthToken(Configurator.API.Token);
        }

        public RestResponse GetProjectByCode(string code)
        {
            apiClient.logger.Info($"Get poject by code: {code}");
            var request = new RestRequest(ProjectByCodeEndpoint).AddUrlSegment("code", code);
            return apiClient.Execute(request);
        }

        public Project GetProjectByCode<ProjectType>(string code) where ProjectType : Project
        {
            apiClient.logger.Info($"Get poject by code: {code}");
            var request = new RestRequest(ProjectByCodeEndpoint).AddUrlSegment("code", code);
            return apiClient.Execute<CommonResultResponse<Project>>(request).Result;
        }

        public RestResponse CreateProject(CreateProjectModel project)
        {
            var request = new RestRequest(ProjectEndpoint, Method.Post);
            request.AddBody(project);
            return apiClient.Execute(request);
        }

        public RestResponse GetAllProjects(int limit, int offset)
        {
            apiClient.logger.Info($"Get projects with querry params: limit {limit}, offset {offset}");
            var request = new RestRequest(GetAllProjectsEndpoint).AddQueryParameter("limit", limit).AddQueryParameter("offset", offset);
            return apiClient.Execute(request);
        }

        public RestResponse DeleteProjectByCode(string code)
        {
            apiClient.logger.Info($"Delete project by code: {code}");
            var request = new RestRequest(ProjectByCodeEndpoint, Method.Delete).AddUrlSegment("code", code);
            return apiClient.Execute(request);
        }
    }
}
