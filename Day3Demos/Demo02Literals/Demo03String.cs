using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demos.Demo02Literals
{
    class Department
    {
        public int id;
        public string name;
        public string location;
    }

    internal class Demo03String
    {
        public static void TestConstructors()
        {
            char[] chars = {'a', 'b', 'c', 'd', 'e', 'f'};

            // Create a string from a character array.
            string string1 = new string(chars);
            Console.WriteLine(string1);

            // Create a string that consists of a character repeated 20 times.
            string string2 = new string('c', 20);
            Console.WriteLine(string2);

            Console.WriteLine("Looped Stars. 5 times");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            Console.WriteLine("Without Looping Stars. 5 times");
            string stars = new string('*', 5);
            Console.WriteLine(stars);
        }

        /// <summary>
        /// Manual logic without using indexOf
        /// </summary>
        /// <param name="sentence"></param>
        public static void TestSubstringAssignment(string sentence)
        {
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    startIndex = i + 1;
                    break;
                }
            }

            for (int j = startIndex; j < sentence.Length; j++)
            {
                if (sentence[j] == ' ')
                {
                    endIndex = j;
                    break;
                }
            }

            int sizeOfWord = endIndex - startIndex;

            string word = sentence.Substring(startIndex, sizeOfWord);
            Console.WriteLine($"[{word}]");
        }

        /// <summary>
        /// Use indexOf to write small and efficient code
        /// </summary>
        /// <param name="sentence"></param>
        public static void TestSubstringAssignment2(string sentence)
        {
            //Someone is going to be sent home!
            //We congratulate you on your success
            //Who goes there!
            int startIndex = sentence.IndexOf(' ') + 1;         // 8    // 3    // 4
            int endIndex = sentence.IndexOf(' ', startIndex);   // 10   // 15   // 8
            
            int sizeOfWord = endIndex - startIndex;             // 2    // 12   // 4

            string word = sentence.Substring(startIndex, sizeOfWord);
            Console.WriteLine($"[{word}]");
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

        /// <summary>
        /// string interpolation formatting
        /// </summary>
        public static void TestFormat()
        {
            DateTime dt = DateTime.Now;
            float temperature = 0.85f;

            string statement1 = string.Format("At {0:t} on {0:D}, the temperature was {1:F1} degrees Fahrenheit.", dt, temperature);
            string statement2 = string.Format("At {0} on {0}, the temperature was {1} degrees Fahrenheit.", dt, temperature);

            string statement3 = $"At {dt:t} on {dt:D}, the temperature was {temperature:F1} degrees Fahrenheit.";
            string statement4 = $"At {dt} on {dt}, the temperature was {temperature} degrees Fahrenheit.";
            
            Console.WriteLine("1." + statement1);
            Console.WriteLine("2." + statement2);
            Console.WriteLine("3." + statement3);
            Console.WriteLine("4." + statement4);
        }        

        /// <summary>
        /// Well formatted, beautiful looking report
        /// List of deparments
        /// string interpolation formatting
        /// </summary>
        public static void TestFormat2()
        {
            Department[] departments ={ 
                new Department { id = 101, name = "Sales", location = "Delhi" },
                new Department { id = 111234, name = "Marketing", location = "Bengaluru" },
                new Department { id = 3, name = "IT", location = "Mumbai" },
                new Department { id = 4, name = "Human Resource Management", location = "Pune" }
            };

            string horizontalLines = new string('=', 56);

            Console.WriteLine(horizontalLines);
            Console.WriteLine($"|{"Id",-10}|{"Name",-27}|{"Location",-15}|");
            Console.WriteLine(horizontalLines);
            foreach (var department in departments)
            {
                Console.WriteLine($"|{department.id,-10}|{department.name,-27}|{department.location, -15}|");
            }
            
            Console.WriteLine(horizontalLines);
        }

        private static void TestFormat3()
        {
            string name = "James Bond";
            string code = "007";

            string test1 = "Hello Mr. " + name + ". Is your code " + code + ". If yes, welcome Mr. " + name;

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello Mr. ").Append(name).Append(". Is your code ").Append(code).Append(". If yes, welcome Mr. ").Append(name);
            string test2 = sb.ToString();

            string test3 = $"Hello Mr. {name}. Is your code {code}. If yes, welcome Mr. {name}";

            string test4 = string.Format("Hello Mr. {0}. Is your code {1}. If yes, welcome Mr. {0}", name, code);
            // Hello Mr. James Bond. Is your code 007. If yes, welcome Mr. James Bond

            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine(test3);
            Console.WriteLine(test4);
        }

        public static void TestCopyTo()
        {
            string strSource = "changed";
            char[] destination = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ', 'a', 'r', 'r', 'a', 'y' };

            Console.WriteLine(destination);
            strSource.CopyTo(0, destination, 4, strSource.Length);
            Console.WriteLine(destination);
        }

        public static void TestCopyTo1()
        {
            string s = "Hello World";
            string s2 = s;

            Console.WriteLine("1." + s);
            Console.WriteLine("2." + s2);

            s2 = "Oh my God!!";
            Console.WriteLine("3." + s);
            Console.WriteLine("4." + s2);
        }

        public static void TestCopyTo2()
        {
            Department d = new Department { id = 101, name = "Sales", location = "Delhi" };
            Department d2 = d;

            Console.WriteLine($"1. {d.id}, {d.name}, {d.location}");    // Sales
            Console.WriteLine($"2. {d2.id}, {d2.name}, {d2.location}"); // Sales

            d2 = new Department { id = 111234, name = "Marketing", location = "Bengaluru" };

            Console.WriteLine($"3. {d.id}, {d.name}, {d.location}");    // Sales
            Console.WriteLine($"4. {d2.id}, {d2.name}, {d2.location}"); // Marketing
        }
    }
}
