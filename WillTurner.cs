using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA4
{
    public class WillTurner : Character
    {
        
        public WillTurner()
        {
            this.Name = "Will Turner";
            AttackBehavior = new Sword();

        }

    }
}