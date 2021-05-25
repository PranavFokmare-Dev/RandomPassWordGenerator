using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassWordGenerator.Interfaces
{
    public abstract class RandomPasswordGenerator
    {
        
        public string GetPassword()
        {
            int defaultSize = 16;
            Options defaultOption = new Options()
            {
                LowerCase = true,
                UpperCase = true,
                Number = true
            };
            return GetPassword(defaultSize,defaultOption);
        }
        public string GetPassword(int size,Options options)
        {
            if (size <= 0)
                throw new ArgumentOutOfRangeException("Size should be greater than 0");
            if (!options.IsValid())
                throw new FormatException("Atleast one of the options must be true");
            return GeneratePassword(size, options);
        }

        private string GeneratePassword(int size, Options options)
        {
            using (IRandomCharacterGenerator rcg = CreateRandomCharGenerator(options))
            {
                StringBuilder passwordSB = new StringBuilder();
                for (int i = 0; i < size; i++)
                {
                    passwordSB.Append(rcg.Next());
                }
                return passwordSB.ToString();
            }
        }
        public abstract IRandomCharacterGenerator CreateRandomCharGenerator(Options option);
       
    }
}
