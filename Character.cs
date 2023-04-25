using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PA4;

namespace PA4
{
    public abstract class Character : ICharacter
    {
        public string Name { get; set; }
        public int HitPoints { get; set; } = 100;
        public int MaxPower { get; set; }
        public int AttackStrength { get; set; }
        public int DefenseStrength { get; set; }
        public IAttack AttackBehavior { get; set; }

        public Character()
        {
            AttackBehavior = new CannonBall();
        }

        public virtual void ShowStats()
        {
            System.Console.WriteLine($"{Name} has {HitPoints} hit points left!");
            System.Console.WriteLine($"{Name} has {AttackStrength} attack strength!");
            System.Console.WriteLine($"{Name} has {DefenseStrength} defense strength!");
        }
    }

}