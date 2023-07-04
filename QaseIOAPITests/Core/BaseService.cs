using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseIOAPITests.Core
{
    public class BaseService
    {
        protected BaseAPIClient apiClient;

        public BaseService(string url)
        {
            this.apiClient = new BaseAPIClient(url);
        }
    }
}
