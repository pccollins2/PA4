using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA4
{
    public class Distract : IAttack
    {
        public int Damage { get; set; }
        public string Name { get; set; }

        public void Attack(Character attacker, Character defender)
            {
                int damage = attacker.AttackStrength;
                double typeBonus = GetTypeBonus(attacker, defender);
                damage = (int)(damage*typeBonus);
                defender.HitPoints = defender.HitPoints - damage;
            }

        public double GetTypeBonus(Character attacker, Character defender)
            {
                if (defender is WillTurner)
                {
                    return 1.2;
                }
                else
                {
                    return 1;
                }
            }
    }
}