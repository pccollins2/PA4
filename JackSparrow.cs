using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PA4;

namespace PA4
{
    public class JackSparrow : Character
    {
        public JackSparrow()
        {
            this.Name = "Jack Sparrow";
            AttackBehavior = new Distract();
        }

    }
}