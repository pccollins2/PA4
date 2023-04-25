using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PA4;

namespace PA4
{
    public interface ICharacter
    {
        public string Name { get; set; }
        public int HitPoints { get; set; }

        void ShowStats();
    }
}