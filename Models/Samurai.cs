using System;

namespace Wizard_Ninja_Samurai.Models
{
    public class Samurai : Human
    {
        public Samurai(string name) : base(name)
        {
            health = 200;
        }
        public override int Attack(Human target)
        {
            base.Attack(target);
            if (target.Health < 50)
            {
                Console.WriteLine($"{Name} has decimated {target.Name} into oblivion!!");
                target.Damage(target.Health);
            }
            return target.Health;
        }
        public int Meditate()
        {
            health = 200;
            Console.WriteLine($"I always knew that I wanted to be someone.");
            return Health;
        }
    }
}