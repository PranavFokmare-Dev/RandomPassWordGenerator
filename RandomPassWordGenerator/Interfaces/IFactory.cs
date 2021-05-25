using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassWordGenerator.Interfaces
{
    public interface IFactory
    {
        List<IRandomCharacter> CreateRandomGenerators(Options opt);
        IRandomCharacter CreateRandomUpperCaseGenerator();
        IRandomCharacter CreateRandomLowerCaseGenerator();
        IRandomCharacter CreateRandomNumberGenerator();
        IRandomCharacter CreateRandomSpecialCharGenerator();

    }
}
