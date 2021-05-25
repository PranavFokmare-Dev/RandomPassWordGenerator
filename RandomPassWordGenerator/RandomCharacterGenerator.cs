using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassWordGenerator.Interfaces
{
    public class RandomCharacterGenerator:IRandomCharacterGenerator
    {
        private readonly IFactory factory;
     
        public RandomCharacterGenerator(IFactory factory)
        {
            this.factory = factory;
        }

        public override char Next()
        {
            int index = GetIndex();
            return RandomGenerators[index].Next();
        }
        private int GetIndex()
        {
            if (RandomGenerators.Count() <= 0)
                throw new ArgumentException("Make sure options are correct");
            if (RandomGenerators.Count() == 1)
            {
                return 0;
            }
            else
            {
                Random rnd = new Random();
                return rnd.Next(RandomGenerators.Count());
            }
                
        }
        public override void Configure(Options options)
        {
            RandomGenerators = factory.CreateRandomGenerators(options);
        }
    }
}
