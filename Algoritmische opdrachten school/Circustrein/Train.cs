using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circustrein
{
    class Train
    {
        public List<Wagon> Wagons { get; private set; } = new List<Wagon>();
        public List<Animal> Animals { get; private set; } = new List<Animal>();

        public void AddAnimal(string Name, string Size, string Diet)
        {
            int SizeInt;
            switch (Size)
            {
                case "Klein":
                    SizeInt = 1;
                    break;

                case "Middelgroot":
                    SizeInt = 3;
                    break;

                default:
                    SizeInt = 5;
                    break;
            }
            Animals.Add(new Animal(Name, SizeInt, Diet));
        }

        private void DistributeCarnivores()
        {
            foreach (var Animal in Animals)
            {
                if (Animal.Diet == "Vlees" && Animal.Added == false)
                {
                    foreach (var Wagon in Wagons)
                    {
                        if (Wagon.CheckCarnivore() == false && Wagon.AnimalFits(Animal.Size) == true)
                        {
                            Wagon.AddAnimal(Animal.Name, Animal.Size, Animal.Diet);
                            Animal.Added = true;
                            break;
                        }
                    }
                    if (Animal.Added == false)
                    {
                        AddWagon(Animal.Name, Animal.Size, Animal.Diet);
                        Animal.Added = true;
                    }
                }
            }
        }

        private void DistributeHerbivores(int Size)
        {
            foreach (var Animal in Animals)
            {
                if (Animal.Added == false && Animal.Size == Size && Animal.Diet == "Planten")
                {
                    foreach (var Wagon in Wagons)
                    {
                        if (Wagon.AnimalFits(Animal.Size) == true && Wagon.AnimalNotEaten(Animal.Size) == true)
                        {
                            Wagon.AddAnimal(Animal.Name, Animal.Size, Animal.Diet);
                            Animal.Added = true;
                            break;
                        }
                    }
                    if (Animal.Added == false)
                    {
                        AddWagon(Animal.Name, Animal.Size, Animal.Diet);
                        Animal.Added = true;
                    }
                }
            }
        }

        public void ResetDistribution()
        {
            Wagons.Clear();
            foreach(var Animal in Animals)
            {
                Animal.Added = false;
            }
        }

        public void DistributeAnimals()
        {
            ResetDistribution();
            DistributeCarnivores();
            DistributeHerbivores(1);
            DistributeHerbivores(3);
            DistributeHerbivores(5);
        }

        private void AddWagon(string Name, int Size, string Diet)
        {
            int NewIncrement = 1;
            foreach (var Wagon in Wagons)
            {
                if (Wagon.Increment >= NewIncrement)
                {
                    NewIncrement = Wagon.Increment + 1;
                }
            }
            Wagons.Add(new Wagon(Name, Size, Diet, NewIncrement));
        }

        public void ClearWagons()
        {
            Wagons.Clear();
            foreach (var Animal in Animals)
            {
                Animal.Added = false;
            }
        }
    }
}
