using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseIOAPITests.Models
{
    public class CommonResultResponse
    {
        public bool Status { get; set; }
        public string? ErrorMessage { get; set; }
        public ICollection<ErrorField>? ErrorFields { get; set; }
    }
    public class CommonResultResponse <T> : CommonResultResponse
    {
        public T? Result { get; set; }
    }

    public class ErrorField
    {
        public string? Field { get; set; }
        public string? Error { get; set; }
    }
}
