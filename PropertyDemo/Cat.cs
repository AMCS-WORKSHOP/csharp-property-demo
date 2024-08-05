using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    internal class Cat : PetBase
    {
        private int _id;
        private string _name;
        public override int Id 
        {
            get { return _id; }
            set { _id = value; }
        }

        public override string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        public override PetType Type => PetType.Cat;

        internal static class Whiskers
        {
            public static int NumberOfWhiskers { get; set; }
        }
    }
}
