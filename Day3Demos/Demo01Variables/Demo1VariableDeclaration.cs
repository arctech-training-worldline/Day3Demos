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
        }
    }
}
