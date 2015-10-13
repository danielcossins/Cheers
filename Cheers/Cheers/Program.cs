using System;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello there! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            for(int i=0; i<name.Length; i++)
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
        }
    }
}