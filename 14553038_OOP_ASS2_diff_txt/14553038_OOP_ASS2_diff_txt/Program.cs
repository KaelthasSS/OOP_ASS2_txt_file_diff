using System;
using System.IO;

namespace _14553038_OOP_ASS2_diff_txt
{
    class Program
    {
        //txt File Assignment
        string txt1a = File.ReadAllText(@"C:\Users\Meg\source\repos\14553038_OOP_ASS2_diff_txt\14553038_OOP_ASS2_diff_txt\obj\GitRepositories_1a.txt");
        string txt1b = File.ReadAllText(@"C:\Users\Meg\source\repos\14553038_OOP_ASS2_diff_txt\14553038_OOP_ASS2_diff_txt\obj\GitRepositories_1b.txt");
        string txt2a = File.ReadAllText(@"C:\Users\Meg\source\repos\14553038_OOP_ASS2_diff_txt\14553038_OOP_ASS2_diff_txt\obj\GitRepositories_2a.txt");
        string txt2b = File.ReadAllText(@"C:\Users\Meg\source\repos\14553038_OOP_ASS2_diff_txt\14553038_OOP_ASS2_diff_txt\obj\GitRepositories_2b.txt");
        string txt3a = File.ReadAllText(@"C:\Users\Meg\source\repos\14553038_OOP_ASS2_diff_txt\14553038_OOP_ASS2_diff_txt\obj\GitRepositories_3a.txt");
        string txt3b = File.ReadAllText(@"C:\Users\Meg\source\repos\14553038_OOP_ASS2_diff_txt\14553038_OOP_ASS2_diff_txt\obj\GitRepositories_3b.txt");

        //Loop Boolean Assignment
        static bool loop = true;

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

                    //Show user that their entered value was invalid
                    if (loop == true) Console.WriteLine("\nERROR: both entered values were not integers between 1 and 6\n____________________________________________________________\n");

                } while (loop == true);

                //Compare Files
                if (FirstFile == SecondFile)
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
                if (Response == 'N')
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
