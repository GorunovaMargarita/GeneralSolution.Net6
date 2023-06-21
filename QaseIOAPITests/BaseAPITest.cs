using NUnit.Framework;
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
        [OneTimeSetUp]
        public void Initial()
        {
            //apiClient = new BaseAPIClient("https://api.qase.io/v1/");
            //apiClient.AddAuthToken("45b857b964827fb6f065320fe41187fa7cdaf28ee1d37a76db9dffdfe0eb83c7");
        }
    }
}
