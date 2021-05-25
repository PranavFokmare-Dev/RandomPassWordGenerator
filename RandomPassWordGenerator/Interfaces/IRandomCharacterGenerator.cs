using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPassWordGenerator.Interfaces
{
    public abstract class IRandomCharacterGenerator:IDisposable
    {
        
        public List<IRandomCharacter> RandomGenerators { get; set; }
        public abstract char Next();
        public abstract void Configure(Options options);

        #region dispose
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    if(RandomGenerators != null)
                    {
                        for(int i = 0; i < RandomGenerators.Count(); i++)
                        {
                            RandomGenerators[i] = null;
                        }
                        RandomGenerators = null;
                    }
                }
                disposedValue = true;
            }
        }

        ~IRandomCharacterGenerator()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
