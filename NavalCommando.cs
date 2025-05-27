using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class NavalCommando : Commando
    {
        public NavalCommando(string Name, string CodeName, object tool ) : base(Name, CodeName, tool)
        {
        }

        public void Swimming()
        {
            Console.WriteLine("The soldier is swimming");
        }

        public override void Attack()
        {
            Console.WriteLine("The naval commando {this.CodeName} is attacking.");
            this.Status = "attack";
        }
    }
}
