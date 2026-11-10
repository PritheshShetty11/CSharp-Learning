using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // My first Git and GitHub practice
            //This is my first program im learning c# programming language
            /*
             * This is a multi line comment
             * This is my first program in c# programming language
             */
            Console.WriteLine("Enter ur name");
            String name = Console.ReadLine();
            //Data types in c# programming language
            int age = 25;
            double height = 5.9;
            bool isStudent = true;
            string studentId = "S12345";
            float weight = 70.5f;
            char gender = 'M';

            Console.WriteLine("Hello" + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Is Student: " + isStudent);
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Gender: " + gender);
        }
    }
}
