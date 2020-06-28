using System;

namespace Wizard_Ninja_Samurai.Models
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175;
        }
        public override int Attack(Human target)
        {
            int dmg = 5 * Dexterity;
            Console.WriteLine($"{Name} has struck down {target.Name} with might and mystery!!!");
            Random rand = new Random();
            if( rand.Next(1,100) <= 20)
            {
                Console.WriteLine($"{Name} has tarnado kicked {target.Name} when they were down!!");
            }
            return target.Damage(dmg);
        }
        public int Steal(Human target)
        {
            target.Damage(5);
            health +=5;
            Console.WriteLine($"{Name} took 5 health from {target.Name}!!");
            return target.Health;
        }
    }
}