using System;
using System.IO;
using System.Collections.Generic;

namespace _14553038_OOP_ASS2_diff_txt
{
    class Program
    {
        //Find txt file paths
        static string Path1a = Path.Combine(Directory.GetCurrentDirectory(), "GitRepositories_1a.txt");
        static string Path1b = Path.Combine(Directory.GetCurrentDirectory(), "GitRepositories_1b.txt");
        static string Path2a = Path.Combine(Directory.GetCurrentDirectory(), "GitRepositories_2a.txt");
        static string Path2b = Path.Combine(Directory.GetCurrentDirectory(), "GitRepositories_2b.txt");
        static string Path3a = Path.Combine(Directory.GetCurrentDirectory(), "GitRepositories_3a.txt");
        static string Path3b = Path.Combine(Directory.GetCurrentDirectory(), "GitRepositories_3b.txt");

        //Append the txt files to arrays
        static string[] Txt1a_Array = File.ReadAllLines(Path1a);
        static string[] Txt1b_Array = File.ReadAllLines(Path1b);
        static string[] Txt2a_Array = File.ReadAllLines(Path2a);
        static string[] Txt2b_Array = File.ReadAllLines(Path2b);
        static string[] Txt3a_Array = File.ReadAllLines(Path3a);
        static string[] Txt3b_Array = File.ReadAllLines(Path3b);

        //Convert each string arrays to only strings
        static string Txt1a = string.Join(" ", Txt1a_Array);
        static string Txt1b = string.Join(" ", Txt1b_Array);
        static string Txt2a = string.Join(" ", Txt2a_Array);
        static string Txt2b = string.Join(" ", Txt2b_Array);
        static string Txt3a = string.Join(" ", Txt3a_Array);
        static string Txt3b = string.Join(" ", Txt3b_Array);

        //Loop Boolean Assignment
        static bool loop = true;

        //Apendable string for more compact file comparison
        static string Txt_1, Txt_2;

        //MAIN METHOD
        static void Main(string[] args)
        {
            //Program Repeat boolean assignment
            bool Repeat = false;

            //Store each chosen file's ID
            int FirstFile, SecondFile;

            Console.WriteLine($"|| Welcome to file comparison application ||\n");

            //Encase program for conditional repeating
            do
            {
                do
                {
                    //Display each file and wait for response
                    Console.WriteLine("\nPlease choose the |FIRST| file by corrosponding ID:\n" +
                    "\n[1] - GitRepositories_1a.txt" +
                    "\n[2] - GitRepositories_1b.txt" +
                    "\n[3] - GitRepositories_2a.txt" +
                    "\n[4] - GitRepositories_2b.txt" +
                    "\n[5] - GitRepositories_3a.txt" +
                    "\n[6] - GitRepositories_3b.txt");
                    FirstFile = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nPlease choose the |SECOND| file by corrosponding ID:\n" +
                    "\n[1] - GitRepositories_1a.txt" +
                    "\n[2] - GitRepositories_1b.txt" +
                    "\n[3] - GitRepositories_2a.txt" +
                    "\n[4] - GitRepositories_2b.txt" +
                    "\n[5] - GitRepositories_3a.txt" +
                    "\n[6] - GitRepositories_3b.txt");
                    SecondFile = Convert.ToInt32(Console.ReadLine());

                    if (((FirstFile >= 1) && (FirstFile <= 6)) && ((SecondFile >= 1) && (SecondFile <= 6)))
                    {
                        loop = false;
                    }

                    //Append strings to additional variables
                    //FirstFile
                    if(FirstFile == 1)
                    {
                        Txt_1 = Txt1a;
                    }
                    else if(FirstFile == 2)
                    {
                        Txt_1 = Txt1b;
                    }
                    else if (FirstFile == 3)
                    {
                        Txt_1 = Txt2a;
                    }
                    else if (FirstFile == 4)
                    {
                        Txt_1 = Txt2b;
                    }
                    else if (FirstFile == 5)
                    {
                        Txt_1 = Txt3a;
                    }
                    else if (FirstFile == 6)
                    {
                        Txt_1 = Txt3b;
                    }

                    //SecondFile
                    if (SecondFile == 1)
                    {
                        Txt_2 = Txt1a;
                    }
                    else if (SecondFile == 2)
                    {
                        Txt_2 = Txt1b;
                    }
                    else if (SecondFile == 3)
                    {
                        Txt_2 = Txt2a;
                    }
                    else if (SecondFile == 4)
                    {
                        Txt_2 = Txt2b;
                    }
                    else if (SecondFile == 5)
                    {
                        Txt_2 = Txt3a;
                    }
                    else if (SecondFile == 6)
                    {
                        Txt_2 = Txt3b;
                    }

                    //Show user that their entered value was invalid
                    if (loop == true) Console.WriteLine("\nERROR: both entered values were not integers between 1 and 6\n____________________________________________________________\n");

                } while (loop == true);

                //Compare File strings
                if (String.Equals(Txt_1, Txt_2))
                {
                    Console.WriteLine("\nBoth files are the same!");
                }
                else
                {
                    Console.WriteLine("\n\nFiles do not match");
                }

                //Ask user to loop the program
                Console.WriteLine("\nDo you want to try again? (Y/N)");
                char Response = Convert.ToChar(Console.ReadLine());
                Response = char.ToUpper(Response);

                //Use loop Response
                if (Response == 'N' || (Response != 'N' && Response != 'Y'))
                {
                    Repeat = false;
                }
                else if (Response == 'Y')
                {
                    Repeat = true;
                }

            } while (Repeat == true);
            
        }
    }
}
