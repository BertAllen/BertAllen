using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooKeeper
{
    class Animal : Food
    {
        public string Name;
        public GenderType Gender;
        public bool Predator;

        public Animal()
        {
            base.IsLive = true;
            
        }

        public void Eat(Food food)
        {
            if (Predator && food.IsLive)
            {
                Console.WriteLine($"Yum Yum, the {this.Name} said, I ate {food.Type}");
            }
            else if (Predator && !food.IsLive) {
                Console.WriteLine("Yuck! the I don't like dead things!!");
            }
            else if (!Predator && !food.IsLive)
            {
                Console.WriteLine("I like to eat it!!");
            }
            else if (!Predator && food.IsLive)
            {
                Console.WriteLine("I don't eat my friends!!");
            }
        }
    }
}
