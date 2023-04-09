using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home4
{
    public class Common
    {
        /// <summary>
        /// Adding quots "" to word
        /// </summary>
        /// <param name="wordWithoutQuots">word without quots</param>
        /// <returns></returns>
        public static string AddQuots(string wordWithoutQuots)
        {
            return String.Format("{0}{1}{0}", "\"", wordWithoutQuots);
        }
        /// <summary>
        /// Removing digits from string 
        /// </summary>
        /// <param name="initialString">string for changing</param>
        /// <returns>string without digits</returns>
        public static string RemoveDigitsFromString(string initialString)
        {
            char[] characters = initialString.ToCharArray();

            foreach (char c in characters)
            {
                if (Char.IsDigit(c))
                {
                    initialString = initialString.Replace(c, '_');
                }
            }
            return String.Join("", initialString.Split("_"));
        }
    }
}
