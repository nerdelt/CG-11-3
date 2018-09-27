using System;

namespace StudentMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
           //creates new student object
           Student student = new Student();
           Console.WriteLine("To display the minimum and maximum quiz score of each student, please press ENTER.");

           //this allows user to press enter 
           Console.ReadLine();

           //reads the text file 
           student.GetStudentData();

           //goes through text file, assigns student's name and min/max
           student.NameMinMax();
           Console.ReadLine();
        }
    }
}
