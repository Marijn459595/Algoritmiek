using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Animal
    {
        public string Name { get; private set; }
        public int Size { get; private set; }
        public string Diet { get; private set; }
        public bool Added;

        public Animal(string Name, int Size, string Diet)
        {
            this.Name = Name;
            this.Size = Size;
            this.Diet = Diet;
        }
    }
}
