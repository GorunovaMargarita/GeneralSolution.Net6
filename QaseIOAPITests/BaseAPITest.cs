using NUnit.Framework;
using QaseIOAPITests.ApiServiceStep;
using QaseIOAPITests.BusinessObject.Services;
using QaseIOAPITests.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseIOAPITests
{
    public class BaseAPITest
    {
        protected BaseAPIClient apiClient;
        protected ProjectService projectService;
        protected ApiProjectSteps apiProjectSteps;

        [OneTimeSetUp]
        public void Initial()
        {
            projectService = new ProjectService();
            apiProjectSteps = new ApiProjectSteps();
        }
    }
}
