// C# program to demonstrate
// initialization
using System;

namespace Day3Demos.Demo01Variables
{
    class Employee
    {
        // only declaration, compiler will
        // provide the default value 0 to it
        public int age;
    }

    class Demo1VariableDeclaration
    {
        // Main Method
        public static void Test()
        {
            // Compile Time Initialization of variable 'x'
            // Assigning value 32 to x
            int x = 32;

            // printing the value
            Console.WriteLine("Value of x is " + x);

            // creating object to access
            // the variable age
            Employee employee = new Employee();

            // printing the value
            Console.WriteLine("Value of y is " + employee.age);

            // Not allowed. Compiler error
            // int salary;
            // Console.WriteLine("Value of salary is " + salary);
        }

        public static void TestVariousNumberSystems()
        {
            int num1 = 100;         // 100 is a decimal literal, (this is the default) => 0 1 2 3 4 5 6 7 8 9
            int num2 = 0xff;        // 0xff is a hexadecimal literal (0x prefix) => 0 1 2 3 4 5 6 7 8 9 0 A B C D E F
            int num3 = 0b1000001;	// Same as writing num4 = 65;  => 0 1

            Console.WriteLine($"num1 = {num1}, num2 = {num2}, num3 = {num3}");
            // num1 = 100, num2 = 58, num3 = 255, num4 = 65
        }

        public static void TestString()
        {
            // Escape sequence character backslash \
            //string s = "This is a "demo" in C#";  // Compile Error
            string s = "This is a \"demo\" in C#";  // OK - with escape sequence
            Console.WriteLine(s);

            //string s1 = "This is a \fenced \foolish string";    // Unexpected output
            string s1 = "This is a \\fenced \\foolish string";      // OK - with escape sequence
            Console.WriteLine(s1);

            // Escape sequence demo
            string s2 = "\'SpiderMan\' \a\a\n\"Please go back home\"";
            Console.WriteLine(s2);
            /*
             Expected output:
             'SpiderMan' 
             "Please go back home"
             */
        }
    }
}
