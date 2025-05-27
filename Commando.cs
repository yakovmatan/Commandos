using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        public string Name { get; }
        public string CodeName { get; }

        public Object Tool { get; }
        public int CountLife { get; protected set; } = 100;
        public string Status { get; protected set; } = "walk";

        public Commando(string Name, string CodeName, object tool)
        {
            this.Name = Name;
            this.CodeName = CodeName;
            Tool = tool;
        }

        public void walk()
        {
            Console.WriteLine("The soldier is walking.");
            this.Status = "walk";
        }

        public void Hide()
        {
            Console.WriteLine("The soldier is hiding.");
            this.Status = "hide";
        }

        public virtual void Attack()
        {
            Console.WriteLine($"The commando soldier {this.CodeName} is attacking.");
            this.Status = "attack";
        }




    }
}
