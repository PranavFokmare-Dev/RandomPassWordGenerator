using RandomPassWordGenerator.Ascii_random_characters.implemntations;
using RandomPassWordGenerator.Interfaces;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomPasswordGenerator gen = new AsciiRandomPasswordGenerator();
            Console.WriteLine(gen.GetPassword(11, new Options() { LowerCase = true, Number = true, SpecialCharacter = false, UpperCase = true }));
        }
    }
}
