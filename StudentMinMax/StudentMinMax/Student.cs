using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


namespace StudentMinMax
{
    class Student
    {
        // creates string array for txt file to go into
        public List<string> Students = new List<string>();

        //creates a list for all the split strings from Students
        public List<string> SplitList = new List<string>();

        //creates list for scores to go into 
        public List<int> Scores = new List<int>();

        //creates string property to be returned 
        public string Name { get; set; }

        public void GetStudentData()

        {
            string line;

            //reads txt file and creates list, each line being item in list. 
            using (StreamReader sr = new StreamReader(@"C:\Users\nerdelt\source\repos\CG-11-3\StudentMinMax\StudentMinMax\studentdata.txt"))

            {
                //while loop to add each line as an element in  list Student
                while ((line = sr.ReadLine()) != null)
                {
                    Students.Add(line);
                }
            }
        }


        public void NameMinMax()

        {
            // creates loop that
            foreach (string s in Students)

            {
               //splits each string into smaller strings and adds them to new list
                SplitList = s.Split(' ').ToList();

                //assigns name
                Name = SplitList[0];

                //removes name to just have int
                SplitList.RemoveAt(0);

                //creates a loop that 
                foreach (string n in SplitList)

                {
                    //Scores.Add(int.Parse(n)); (another way to do this)
                    //converts strings to int and adds them to int list
                    Scores.AddRange(SplitList.ConvertAll(int.Parse));
                }

                    //finds min/max of scores in list
                    int min = Scores.Min();
                    int max = Scores.Max();

                    //clears list 
                    Scores = new List<int>();

                    //writes each students name and score 
                    Console.WriteLine($"{ Name}'s minimum score: {min}; maximum score: {max}.\n");
            }
        }
    }
}
