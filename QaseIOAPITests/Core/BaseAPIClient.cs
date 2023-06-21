using QaseIOAPITests.Models;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseIOAPITests.Core
{
    public class BaseAPIClient
    {
        private RestClient restClient;

        public BaseAPIClient(string url)
        {
            var option = new RestClientOptions(url)
            {
                MaxTimeout = 10000,
                ThrowOnAnyError = false
            };
            restClient = new RestClient(option);
            restClient.AddDefaultHeader("Content-Type", "application/json");
        }

        public void AddAuthToken(string Token)
        {
            restClient.AddDefaultHeader("Token", Token);
        }

        public RestResponse Execute(RestRequest request)
        {
            var response = restClient.Execute(request);
            return response;
        }

        public T Execute<T>(RestRequest request)
        {
            var response = restClient.Execute<T>(request);
            return response.Data;
        }
    }
}
