using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando c = new Commando();
            Console.WriteLine(c.Name);
            //c.Name = "dfgks";
        }
    }
}
