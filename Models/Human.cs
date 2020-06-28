using System;

namespace Wizard_Ninja_Samurai.Models
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;

        public int Health
        {
            get { return health; }
        }

        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Name: {Name}\nStrength: {Strength}\nDexterity: {Dexterity}\nIntelligenxe: {Intelligence}\nHealth: {Health}");
        }

        public int Damage(int dmg)
        {
            health -= dmg;
            if(health <=0)
            {
                Console.WriteLine($"{Name} has fallen.");
            }
            return health;
        }

        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3;
            target.health -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.health;
        }
    }
}