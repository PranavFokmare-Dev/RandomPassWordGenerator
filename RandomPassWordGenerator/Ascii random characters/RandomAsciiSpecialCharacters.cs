using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassWordGenerator.Ascii_random_characters
{
    class RandomAsciiSpecialCharacters : IRandomCharacter
    {
        int[,] asciiSequence;
        public RandomAsciiSpecialCharacters()
        {
            asciiSequence = new int[4, 2] { { 33, 47 },{ 58, 64 },{ 91, 96 },{ 123, 126 } };
        }

        public char Next()
        {
            Random random = new Random();
            int index = random.Next(0, asciiSequence.Length);
            int start = asciiSequence[index,0];
            int end = asciiSequence[index, 1];
            return Convert.ToChar(random.Next(start, end));
        }
    }
}
