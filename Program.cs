using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pword = GetPword();
            int timeLim = GetInt(0);
            int maxThreads = GetInt(1);
        }

        static string GetPword()
        {
            string pword = string.Empty;
            bool inputValid = false;

            while(!inputValid)
            {
                Console.WriteLine("Enter the password to be guessed: ");

                pword = Console.ReadLine();

                inputValid = ValidateInput(pword, 0);
            }

            Console.Clear();
            return pword;
        }

        static int GetInt(int type)
        {
            Console.Clear();
            return 0;
        }

        static bool ValidateInput(string input, int type)
        {
            bool isValid = false;

            switch(type)
            {
                //0 is password input
                case 0:
                    long password = 0;

                    isValid = long.TryParse(input, out password);

                    if (!isValid)
                    {
                        Console.WriteLine("\nIncorrect. Must input a numeric password between 6-18 digits in length.\n");
                    }

                    else if (input.Length < Constants.MIN_PWORD_DIGITS || input.Length > Constants.MAX_PWORD_DIGITS)
                    {
                        isValid = false;
                        Console.WriteLine("\nIncorrect. Must input a numeric password between 6-18 digits in length.\n");
                    }

                    break;

                //1 is time limit input
                case 1:
                    break;

                //2 is max threads input
                case 2:
                    break;
            }

            return isValid;
        }
    }

    public static class Constants
    {
        public const int MIN_PWORD_DIGITS = 6;
        public const int MAX_PWORD_DIGITS = 18;
    }
}
