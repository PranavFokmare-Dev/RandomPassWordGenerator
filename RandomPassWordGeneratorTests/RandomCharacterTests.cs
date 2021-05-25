using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomPassWordGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomPassWordGenerator.Interfaces;
using RandomPassWordGenerator.Ascii_random_characters.implemntations;

namespace RandomPassWordGenerator.Tests
{
    [TestClass()]
    public class RandomCharacterTests
    {
        [TestMethod()]
        public void password_size11OptionsTrue()
        {
            RandomPasswordGenerator gen = new AsciiRandomPasswordGenerator();
            int size = 11;
            Options option = new Options() { UpperCase = true };

            string pw = gen.GetPassword(size, option);

            Assert.AreEqual(size, pw.Length);
        }

        [TestMethod()]
        public void password_InvalidSize_test()
        {
            RandomPasswordGenerator gen = new AsciiRandomPasswordGenerator();
            int size = -1;
            Options option = new Options();
            
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => { gen.GetPassword(size, option); });
        }

        public void password_InvalidOptions_test()
        {
            RandomPasswordGenerator gen = new AsciiRandomPasswordGenerator();
            int size = 11;
            Options option = new Options();
            Assert.ThrowsException<FormatException>(() => { gen.GetPassword(size,option); });
        }

        [TestMethod()]
        public void RandomCharacterGenerator_Configure_Test()
        {
            RandomPasswordGenerator gen = new AsciiRandomPasswordGenerator();
            IRandomCharacterGenerator rcg = gen.CreateRandomCharGenerator(new Options() { LowerCase=false,Number=false, SpecialCharacter = false,UpperCase=true});
            Assert.IsNotNull(rcg);
            Assert.IsNotNull(rcg.RandomGenerators);
            Assert.AreEqual(1, rcg.RandomGenerators.Count);
        }
        
        [TestMethod()]
        public void password_default_case()
        {
            RandomPasswordGenerator gen = new AsciiRandomPasswordGenerator();
            String pw = gen.GetPassword();
            Assert.AreEqual(16, pw.Length);
        }
    }
}

namespace RandomPassWordGeneratorTests
{
    class RandomCharacterTests
    {
    }
}
