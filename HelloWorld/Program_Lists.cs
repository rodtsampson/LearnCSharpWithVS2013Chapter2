using System;

namespace Lists
{
    //new namespace for getting lists
    //lists allow us to collect without knowing
    //in advance how many
    using System.Collections.Generic;
    class Student
    {
        //array for storing student grades
        private int[] grades;
        public Student(int[] marks)
        {
            //set instance variable
            grades = marks;
        }
        public double GetAverageGrade()
        {
            int sum = 0;//sum of grades
            foreach (int gr in this.grades)
            {
                sum += gr;
            }
            // sum of values/number of values
            return sum / grades.Length;
        }
    }
    class Program
    {
        //static void Main()
        //{
        //    //prompt data entry person
        //    Console.WriteLine("Enter Grades:");
        //    //use list for collecting grades
        //    List<int> values = new List<int>();
        //    string s;//input from user
        //    int mark;//attempted conversion result
        //             //spin, asking for input
        //    while (true)
        //    {
        //        s = Console.ReadLine();//input from user
        //                               //attemp to convert to integer
        //        if (int.TryParse(s, out mark))
        //        {
        //            values.Add(mark);
        //        }
        //        else if (s == "Exit")
        //        {
        //            //to exit in case
        //            //user wants to quit
        //            break;
        //        }
        //        else
        //        {
        //            //continues the loop
        //            //in case some garbage is entered
        //            continue;
        //        }
        //    }
        //    //make student with list converted to array form
        //    Student st = new Student(values.ToArray());
        //    //display average grade for student
        //    Console.WriteLine("Average grade is " + st.GetAverageGrade());
        //}
    }
}