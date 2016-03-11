using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper
{
    class Program
    {
class enclosure
        {

        }

        static void Main(string[] args)
        {
            Animal lion = new Animal
            {
                Gender = GenderType.Male,
                Name = "Lion",
                Predator = true,
            };
            Enclosure cage = new Enclosure
            {
                Name = "Lion Pen",
                Habitat = "Savana",
            };
            Food food = new Food
            {
                Type = "Jonny",
                IsLive = false,
            };

            Animal sally = new Animal
            {
                Gender = GenderType.Female,
                Name = "Human",
                Predator = false,
                Type = "Sally",

            };

            lion.Eat(food);
            lion.Eat(sally);

            cage.AddOccupant(lion);
            Console.ReadKey();
        }
    }
}
