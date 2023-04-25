using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA4
{
    public class DavyJones : Character
    {
        public DavyJones()
        {
            this.Name = "Davy Jones";
            AttackBehavior = new CannonBall();
        }
    }

}