using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper
{
    class Enclosure
    {
        public string Name;
        public string Habitat;
        public List<Animal> Occupants = new List<Animal>();
            public void AddOccupant(Animal animal) {
            
               Occupants.Add(animal);
            }
        public void Log()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Habitat: {Habitat}");
            Console.WriteLine();
        }
    }
}
