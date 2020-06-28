using System;
using Wizard_Ninja_Samurai.Models;

namespace Wizard_Ninja_Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja vasea = new Ninja("Mr.Vasea");
            Ninja michelle = new Ninja("Michelle");
            michelle.Attack(vasea);
            vasea.ShowStats();
            Wizard ana = new Wizard("Ana");
            ana.Heal(vasea);
            vasea.ShowStats();
            Samurai david = new Samurai("David");
            while(michelle.Health > 0)
            {
                david.Attack(michelle);
                vasea.Attack(michelle);
                ana.Attack(michelle);
            }
        }
    }
}
