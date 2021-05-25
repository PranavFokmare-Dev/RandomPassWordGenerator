using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassWordGenerator.Ascii_random_characters
{
    class RandomAsciiLowerCase : IRandomCharacter
    {
        public char Next()
        {
            Random random = new Random();
            int startAsciLower = 97;
            int endAsciLower = 122;
            return Convert.ToChar(random.Next(startAsciLower,endAsciLower));
        }
    }
}
