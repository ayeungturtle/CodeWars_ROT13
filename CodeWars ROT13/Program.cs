using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_ROT13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rot13("abc3 abc bcd4"));
            Console.ReadLine();
        }

        public static string Rot13(string input)
        {
            string[] alphabet = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" };
            string rotSentence = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (alphabet.Contains(input[i].ToString()))
                {
                    for (int j = 0; j < alphabet.Length; j++)
                    {
                        if (input[i].ToString() == alphabet[j])
                        {
                            rotSentence += alphabet[j + 13];
                            break;
                        }
                    }
                }
                else
                {
                    rotSentence += input[i];
                }
            }
            return rotSentence;
        }
    }
}
