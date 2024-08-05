using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    internal abstract class PetBase : IPet
    {
        private static int _latestMicrochipNumber = 123;
      
        public int MicrochipNumber => _latestMicrochipNumber;

        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract PetType Type { get; }

        public PetBase()
        {
            _latestMicrochipNumber++;
        }

        public override string ToString()
        {
            return $"\ntype: {Type}\nid: {Id}\nname: {Name}\nchip: {MicrochipNumber}";
        }
    }
}
