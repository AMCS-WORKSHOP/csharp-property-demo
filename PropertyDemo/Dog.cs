using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    internal class Dog : PetBase
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

        public override PetType Type => PetType.Dog;
    }
}
