using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassWordGenerator.Ascii_random_characters
{
    class RandomAsciiNumber : IRandomCharacter
    {
        public char Next()
        {
            Random random = new Random();
            int startAsciNumber = 48;
            int endAsciNumber = 57;
            return Convert.ToChar(random.Next(startAsciNumber, endAsciNumber));
        }
    }
}
