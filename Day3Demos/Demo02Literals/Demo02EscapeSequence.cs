using System;
using System.Text;

namespace Day3Demos.Demo02Literals
{
    internal class Demo02EscapeSequence
    {
        public static void Test()
        {
            Console.WriteLine();

            string path1 = "C:\\Users\\avinash\\OneDrive\\Documents\\Training\\C# Sessions\\Day 3\\log1.txt";
            string path2 = @"C:\Users\avinash\OneDrive\Documents\Training\C# Sessions\Day 3\log1.txt";
            Console.WriteLine(path1);
            Console.WriteLine(path2);
            Console.WriteLine();

            //string text1 = @"This is a "string." in C#.";   // error
            //string text2 = @"This is a \"string\" in C#.";  // error
            string text3 = "This is a \"string\" in C#."; 	// valid
            Console.WriteLine(text3);
            
            Console.WriteLine();

            string strOld = "C-306, Morya House,\nOff Oshiwara Link Road,\nAndheri(W), Mumbai,\nPin: 400061";
            Console.WriteLine(strOld);
            Console.WriteLine();

            string str = 
@"C-306, Morya House,
Off Oshiwara Link Road,
Andheri(W), Mumbai,
Pin: 400061";

            Console.WriteLine(str);
            Console.WriteLine();
        }

        // string is immutable so using + is very inefficient
        public static void TestConcatenation()
        {
            string firstName = "James";
            string lastName = "Bond";
            string code = "007";
            string agent = "Mr. " + firstName + " " + lastName + ", Code: " + code;

            Console.WriteLine("Concatenation Example!");
            Console.WriteLine(agent);
            Console.WriteLine();
        }

        // stringbuilder is more efficent for multiple concatenations
        public static void TestStringBuilder()
        {
            string firstName = "James";
            string lastName = "Bond";
            string code = "007";

            Console.WriteLine("StringBuilder Example!");
            StringBuilder sb = new StringBuilder();

            sb.Append("Mr. ").Append(firstName).Append(" ").Append(lastName).Append(", Code: ").Append(code);

            Console.WriteLine(sb.ToString());
            Console.WriteLine();
        }

        // $ was introduced in C# 6.0
        public static void TestStringInterpolation()
        {
            string firstName = "James";
            string lastName = "Bond";
            string code = "007";
            
            Console.WriteLine("Interpolation Example!");
            string agent = $"Mr. {firstName} {lastName}, Code: {code}";
            Console.WriteLine(agent);
            Console.WriteLine();

            string statement = $"{firstName} changed his behaviour at pivotal ages {{5, 11, 14, 20}}.";
            Console.WriteLine(statement);
            Console.WriteLine();
        }
    }
}
