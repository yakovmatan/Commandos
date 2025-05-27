using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal abstract class Firearm
    {
        public string Name { get; }
        public string Maker { get; }
        public int Ammocount { get; protected set; }

        public Firearm(string name, string maker, int ammocount )
        {
            Name = name;
            Maker = maker;
            Ammocount = ammocount;
        }
    }
}
