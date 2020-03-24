using System;
using System.IO;

namespace _14553038_OOP_ASS2_diff_txt
{
    class Program
    {
        //txt File Assignment
        static string Txt1a = File.ReadAllText(@"C:\Users\Meg\source\repos\14553038_OOP_ASS2_diff_txt\14553038_OOP_ASS2_diff_txt\obj\GitRepositories_1a.txt");
        static string Txt1b = File.ReadAllText(@"C:\Users\Meg\source\repos\14553038_OOP_ASS2_diff_txt\14553038_OOP_ASS2_diff_txt\obj\GitRepositories_1b.txt");
        static string Txt2a = File.ReadAllText(@"C:\Users\Meg\source\repos\14553038_OOP_ASS2_diff_txt\14553038_OOP_ASS2_diff_txt\obj\GitRepositories_2a.txt");
        static string Txt2b = File.ReadAllText(@"C:\Users\Meg\source\repos\14553038_OOP_ASS2_diff_txt\14553038_OOP_ASS2_diff_txt\obj\GitRepositories_2b.txt");
        static string Txt3a = File.ReadAllText(@"C:\Users\Meg\source\repos\14553038_OOP_ASS2_diff_txt\14553038_OOP_ASS2_diff_txt\obj\GitRepositories_3a.txt");
        static string Txt3b = File.ReadAllText(@"C:\Users\Meg\source\repos\14553038_OOP_ASS2_diff_txt\14553038_OOP_ASS2_diff_txt\obj\GitRepositories_3b.txt");

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
