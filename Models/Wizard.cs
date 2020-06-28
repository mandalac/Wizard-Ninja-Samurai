using System;

namespace Wizard_Ninja_Samurai.Models
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Intelligence = 25;
            health = 50;
        }
        public override int Attack(Human target)
        {
            int dmg = 5 * Intelligence;
            health += dmg;
            Console.WriteLine($"{Name} has struck down {target.Name} with magic and mystery!!!");
            return target.Damage(dmg);
        }
        public int Heal(Human target)
        {
            int heal = 10 * Intelligence;
            Console.WriteLine($"{Name} healed {target.Name} and restored them to enlightenment!!");
            if (target.Health < 0)
            {
                target.Damage(target.Health + -heal);
                return target.Health;
            }
            return target.Damage(-heal);
        }
    }
}
