using System;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello there! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hey " + name + ", what's your birthday? (MM/DD)");
            string birthday = Console.ReadLine();
            for (int i=0; i<name.Length; i++)
            {
                /*This checks for upper and lower case*/
                bool isVowel = "halfnorsemix".IndexOf(name[i].ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0;
                if (isVowel){
                    Console.WriteLine("Give me an "+Char.ToLower(name[i])+" ... " + name[i]);
                }
                else
                {
                    Console.WriteLine("Give me a "+Char.ToLower(name[i])+" ... " + name[i]);
                }
            }
            Console.WriteLine("Gooooooooooo " + name + "!");

            //Birthday----------------------------
            DateTime today = DateTime.Now;
            DateTime convertedBD = DateTime.Parse(birthday);

            int difference = (convertedBD-today).Days;
            //difference++;
            if (difference < 0)
            {
                difference = 365 + difference;
            }
            if(difference == 0)
            {
                Console.WriteLine("It's your birthday!");
            }
            else
            {
                Console.WriteLine(difference + " days till your birthday");
            }

            Console.WriteLine("Press any key to finish . . .");
            Console.ReadKey();
        }
    }
}