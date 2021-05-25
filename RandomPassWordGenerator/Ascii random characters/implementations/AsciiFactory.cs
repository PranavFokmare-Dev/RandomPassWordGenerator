using RandomPassWordGenerator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassWordGenerator.Ascii_random_characters.implemntations
{
    public class AsciiFactory : IFactory
    {
        public List<IRandomCharacter> CreateRandomGenerators(Options opt)
        {
            List<IRandomCharacter> generators = new List<IRandomCharacter>();
            if (opt.UpperCase)
                generators.Add(CreateRandomUpperCaseGenerator());
            if (opt.LowerCase)
                generators.Add(CreateRandomLowerCaseGenerator());
            if (opt.Number)
                generators.Add(CreateRandomNumberGenerator());
            if (opt.SpecialCharacter)
                generators.Add(CreateRandomSpecialCharGenerator());
            return generators;
        }

        public IRandomCharacter CreateRandomLowerCaseGenerator()
        {
            return new RandomAsciiLowerCase();
        }

        public IRandomCharacter CreateRandomNumberGenerator()
        {
            return new RandomAsciiNumber();
        }

        public IRandomCharacter CreateRandomSpecialCharGenerator()
        {
            return new RandomAsciiSpecialCharacters();
        }

        public IRandomCharacter CreateRandomUpperCaseGenerator()
        {
            return new RandomAsciiUpperCase();
        }
    }
}
