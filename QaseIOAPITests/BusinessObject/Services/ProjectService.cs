﻿using QaseIOAPITests.BusinessObject.Model;
using QaseIOAPITests.Core;
using QaseIOAPITests.Models;
using RestSharp;


namespace QaseIOAPITests.BusinessObject.Services
{
    public class ProjectService : BaseService
    {
        public string ProjectEndpoint = "/project";
        public string GetProjectByCodeEndpoint = "/project/{code}";
        public string GetAllProjectsEndpoint = "/project?limit={limit}&offset={offset}";
        public ProjectService() : base("https://api.qase.io/v1")
        {
            apiClient.AddAuthToken("45b857b964827fb6f065320fe41187fa7cdaf28ee1d37a76db9dffdfe0eb83c7");
        }

        public RestResponse GetProjectByCode(string code)
        {
            var request = new RestRequest(GetProjectByCodeEndpoint).AddUrlSegment("code", code);
            return apiClient.Execute(request);
        }

        public Project GetProjectByCode<ProjectType>(string code) where ProjectType : Project
        {
            var request = new RestRequest(GetProjectByCodeEndpoint).AddUrlSegment("code", code);
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
            var request = new RestRequest(GetAllProjectsEndpoint).AddQueryParameter("limit", limit).AddQueryParameter("offset", offset);
            return apiClient.Execute(request);
        }

        public RestResponse DeleteProjectByCode(string code)
        {
            var request = new RestRequest(GetProjectByCodeEndpoint, Method.Delete).AddUrlSegment("code", code);
            return apiClient.Execute(request);
        }
    }
}
