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
        public string Ammocount { get; protected set; }
    }
}
