using RandomPassWordGenerator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassWordGenerator.Ascii_random_characters.implemntations
{
    public class AsciiRandomPasswordGenerator : RandomPasswordGenerator
    {
        public override IRandomCharacterGenerator CreateRandomCharGenerator(Options option)
        {
            var rcg = new RandomCharacterGenerator(new AsciiFactory());
            rcg.Configure(option);
            return rcg;

        }
    }
}
