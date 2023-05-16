using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home9
{
    public class SalaryException : Exception
    {
        public SalaryException(string message) : base(message) 
        { 
        }
    }
}
