using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Wagon
    {
        public List<Animal> Animals = new List<Animal>();
        public int Points { get; private set; }
        private bool Carnivore { get; set; } = false;
        public int Increment { get; private set; }

        public Wagon(string Name, int Size, string Diet, int Increment)
        {
            AddAnimal(Name, Size, Diet);
            this.Increment = Increment;
        }

        public void AddAnimal(string Name, int Size, string Diet)
        {
            Animals.Add(new Animal(Name, Size, Diet));
            if (Diet == "Vlees")
            {
                Carnivore = true;
            }
            Points += Size;
        }

        public bool CheckCarnivore()
        {
            return Carnivore;
        }

        public bool AnimalFits(int Size)
        {
            if (10 - Points >= Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public bool AnimalNotEaten(int NewSize)
        {
            bool NotEaten = true;
            if (Carnivore == true)
            {
                foreach (var Animal in Animals)
                {
                    if (Animal.Size >= NewSize && Animal.Diet == "Vlees")
                    {
                        NotEaten = false;
                        break;
                    }
                }
                return NotEaten;
            }
            else
            {
                return true;
            }
        }
    }
}
