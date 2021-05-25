using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassWordGenerator.Ascii_random_characters
{
    class RandomAsciiUpperCase : IRandomCharacter
    {
        public char Next()
        {
            Random random = new Random();
            int startAsciUpper = 65;
            int endAsciUpper = 90;
            return Convert.ToChar(random.Next(startAsciUpper, endAsciUpper));
        }
    }
}
