using System;
using System.Collections.Generic;
using System.Text;

namespace StudentNames
{
    class Logic
    {
        public int WordCount { get; set; }

        public int CountWords(string studentdata)
        {
            WordCount = studentdata.Split().Length;
            return WordCount;
        }

        public string RemoveScores(string studentdata)
        {
            //if there are more than 7 words (including the student's name)...
            //print the line, not including any numbers
            //we do this by looping through each letter of the line
            //and replacing any numbers we find with an empty string.
            if (WordCount > 7)
            {
                for (int i = 0; i < studentdata.Length; i++)
                {
                    if (studentdata[i] == '1')
                    {
                        studentdata = studentdata.Replace("1", "");
                    }
                    else if (studentdata[i] == '2')
                    {
                        studentdata = studentdata.Replace("2", "");
                    }
                    else if (studentdata[i] == '3')
                    {
                        studentdata = studentdata.Replace("3", "");
                    }
                    else if (studentdata[i] == '4')
                    {
                        studentdata = studentdata.Replace("4", "");
                    }
                    else if (studentdata[i] == '5')
                    {
                        studentdata = studentdata.Replace("5", "");
                    }
                    else if (studentdata[i] == '6')
                    {
                        studentdata = studentdata.Replace("6", "");
                    }
                    else if (studentdata[i] == '7')
                    {
                        studentdata = studentdata.Replace("7", "");
                    }
                    else if (studentdata[i] == '8')
                    {
                        studentdata = studentdata.Replace("8", "");
                    }
                    else if (studentdata[i] == '9')
                    {
                        studentdata = studentdata.Replace("9", "");
                    }
                    else if (studentdata[i] == '0')
                    {
                        studentdata = studentdata.Replace("0", "");
                    }
                    else
                    {

                    }
                }
                Console.WriteLine(studentdata);
            }
            return studentdata;
        }

        public void Run()
        {
            Student Student = new Student();

            Student.StudentData = Student.ReadData();

            while (Student.StudentData != null)
            {
                CountWords(Student.StudentData);
                RemoveScores(Student.StudentData);
                Student.StudentData = Student.ReadData();
            } 

            Console.ReadLine();
        }

}
}
