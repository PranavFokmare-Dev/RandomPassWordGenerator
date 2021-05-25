using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassWordGenerator.Interfaces
{
    public class Options
    {
        public bool UpperCase { get; set; }
        public bool LowerCase { get; set; }
        public bool Number { get; set; }
        public bool SpecialCharacter { get; set; }

        public bool IsValid()
        {
            if (AtleastOneOptionTrue())
                return true;
            return false;
        }
        private bool AtleastOneOptionTrue()
        {
            return UpperCase || LowerCase || Number || SpecialCharacter;
        }
    }
}
