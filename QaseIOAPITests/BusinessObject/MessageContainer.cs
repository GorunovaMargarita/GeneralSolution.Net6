using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseIOAPITests.BusinessObject
{
    public class MessageContainer
    {
        public static string NotFoundError(string entityName) => $"{entityName} not found";
        public const string DataInvalidError = "Data is invalid.";
        public static string ProjectCodeNotUnique = "Project with the same code already exists";
    }
}
