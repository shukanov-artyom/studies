using System;
using System.IO;
using Library;

namespace ConsoleApplication
{
    public class Program
    {
        private static readonly char[] Alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public static void Main(string[] args)
        {
            string phrase;
            if (args.Length == 0)
            {
                Console.WriteLine("Enter a phrase");
                phrase = Console.ReadLine();
            }
            else
            {
                if (!File.Exists(args[0]))
                {
                    Console.WriteLine("Enter a valid file name");
                    return;
                }
                phrase = File.ReadAllText(args[0]);
            }

            CharacterCounter counter = new CharacterCounter();

            counter.ParseString(phrase);

            foreach (var letter in Alphabet)
            {
                Console.WriteLine("{0} : {1}", letter, counter.GetCountForLetter(letter));
            }
        }
    }
}
