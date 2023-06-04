using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home13.TestData
{
    public class TestUsers
    {
        private static string commonPass = "secret_sauce";

        public static User Standart = new User("standard_user", commonPass);
        public static User Locked = new User("locked_out_user", commonPass);
        public static User Problem = new User("problem_user", commonPass);
        public static User PerfomanceGlitch = new User("performance_glitch_user", commonPass);
        public static User UnknownLoginPass = new User("Unknown", "Unknown");
    }
}
