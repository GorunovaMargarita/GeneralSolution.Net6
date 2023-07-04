using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseIOAPITests.BusinessObject.Model
{
    public class CreateProjectModel
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Access { get; set; }
        public string Group { get; set; }

        public override string ToString()
        {
            return $"\r\nCreateProjectModel: \r\n Title: {Title}, \r\n Code: {Code}, \r\n Description: {Description}, \r\n Access: {Access}, \r\n Group: {Group}";
        }
    }
}
