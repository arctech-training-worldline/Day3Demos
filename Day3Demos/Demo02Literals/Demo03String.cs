using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demos.Demo02Literals
{
    internal class Demo03String
    {
        public static void TestConstructors()
        {
            char[] chars = { 'w', 'o', 'r', 'd' };

            // Create a string from a character array.
            string string1 = new string(chars);
            Console.WriteLine(string1);

            // Create a string that consists of a character repeated 20 times.
            string string2 = new string('c', 20);
            Console.WriteLine(string2);
        }

        public static void TestSubstring()
        {
            string sentence = "This lion is scary.";
            
            // Extract the second word.
            int startPosition = sentence.IndexOf(" ") + 1;
            int endPosition = sentence.IndexOf(" ", startPosition);

            string word2 = sentence.Substring(startPosition, endPosition - startPosition);
            Console.WriteLine("Second word: " + word2);
            // The example displays the following output:
            //       Second word: lion
        }

        public static void TestFormat()
        {
            string statement = string.Format("At {0:t} on {0:D}, the temperature was {1:F1} degrees Fahrenheit.",
                              DateTime.Now, 0.85);

            Console.WriteLine(statement);
        }
    }
}
