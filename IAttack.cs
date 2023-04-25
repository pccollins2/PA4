using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA4
{
    public interface IAttack
    {
    public string Name { get; set; }
    public int Damage { get; set; }

    public void Attack(Character attacker, Character defender);

    double GetTypeBonus(Character attacker, Character defender);
    }
}