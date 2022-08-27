using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortDemo
{
    public class Anagram
     {
        /// <summary>
        /// Anagram - name formed by rearranging the 
        /// letters of another, such as spar, formed from rasp.
        /// </summary>
        public void checkAnagram()
        {
            string str1 = "heater";
            string str2 = "reheai";

            //compre strings according to ACII values of char so lower used
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            string val1 = new string(ch1);
            string val2 = new string(ch2);

            Console.WriteLine(val1);
            Console.WriteLine(val2);

            if(val1 == val2)
            {
                Console.WriteLine("String are anagram");
            }
            else
            {
                Console.WriteLine("No anagram");
            }
        }
    }
}
