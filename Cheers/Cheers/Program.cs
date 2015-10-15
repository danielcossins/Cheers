using System;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello there! What is your name?");
            string name = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                /*This checks for upper and lower case*/
                bool isVowel = "halfnorsemix".IndexOf(name[i].ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0;
                if (isVowel)
                {
                    Console.WriteLine("Give me an " + Char.ToLower(name[i]) + " ... " + name[i]);
                }
                else
                {
                    Console.WriteLine("Give me a " + Char.ToLower(name[i]) + " ... " + name[i]);
                }
            }
            Console.WriteLine("Gooooooooooo " + name + "!");

            //Birthday----------------------------
            Console.WriteLine("Hey " + name + ", what's your birthday? (MM/DD)");
            string birthday = Console.ReadLine();
            DateTime today = DateTime.Now;
            findBD(birthday, today);

            Console.WriteLine("Press any key to finish . . .");
            Console.ReadKey();
        }

        private static void findBD(string birthday, DateTime today)
        {
            try
            {
                DateTime convertedBD = DateTime.Parse(birthday);
                int difference = (convertedBD - today).Days;
                difference++;
                if (difference < 0)
                {
                    difference = 365 + difference;
                }
                if (difference == 0)
                {
                    if (convertedBD.Day == today.Day)
                    {
                        Console.WriteLine("It's your birthday!");
                    }
                    else
                    {
                        if (convertedBD.Day > today.Day)
                        {
                            Console.WriteLine(1 + " day till your birthday");
                        }
                        else
                        {
                            Console.WriteLine("365 days till your birthday");
                        }
                    }
                }
                else
                {
                    Console.WriteLine(difference + " days till your birthday");
                }
                return;
            }
            catch(FormatException)
            {
                Console.WriteLine("not a valid birthday");
                findBD(Console.ReadLine(), DateTime.Today);
            }
        }
    }
}