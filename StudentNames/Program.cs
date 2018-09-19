using System;
using System.IO;

namespace StudentNames
{
    class Program
    {
        static void Main(string[] args)
        {
            String studentdata;
            int wordsCount;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                //NOTE: update this for laptop
                StreamReader sr = new StreamReader("C:\\Users\\Owner\\Documents\\Visual Studio 2017\\Projects\\Homework and Study\\StudentNames\\studentdata.txt");

                //Read the first line of text
                //count the number of words in the line of text
                studentdata = sr.ReadLine();
                wordsCount = studentdata.Split().Length;

                //Continue to read (and count) until you reach end of file
                while (studentdata != null)
                {
                    //if there are more than 7 words (including the student's name)...
                    //print the line, not including any numbers
                    //we do this by looping through each letter of the line
                    //and replacing any numbers we find with an empty string.
                    if (wordsCount > 7)
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
                        //Read the next line
                        //and update the word count
                        studentdata = sr.ReadLine();
                        wordsCount = studentdata.Split().Length;
                    }
                    else
                    {
                        //Read the next line
                        //and update the word count
                        studentdata = sr.ReadLine();
                        wordsCount = studentdata.Split().Length;
                    }

                }

                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
                Console.ReadLine();
            }
        }
    }
}
