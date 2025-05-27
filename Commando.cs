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
        public int CountLife { get; private set; } = 100;
        public string status { get; private set; } = "walk";

        public Commando(string Name, string CodeName, object tool)
        {
            this.Name = Name;
            this.CodeName = CodeName;
            Tool = tool;
        }

        public void walk()
        {
            Console.WriteLine("The soldier is walking.");
            this.status = "walk";
        }

        public void Hide()
        {
            Console.WriteLine("The soldier is hiding.");
            this.status = "hide";
        }

        public void Attack()
        {
            Console.WriteLine($"The soldier {this.CodeName} attacking.");
            this.status = "attack";
        }




    }
}
