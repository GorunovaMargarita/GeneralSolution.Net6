using NLog;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask15
{
    public class Log
    {
        private static Log? instance;
        private static Logger logger; //= LogManager.GetCurrentClassLogger();
        public Logger Logger { get { return logger; } }
        public static Log Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Log();
                }

                return instance;
            }
        }
        private Log()
        {
            logger = LogManager.GetCurrentClassLogger();
        }
    }
}
