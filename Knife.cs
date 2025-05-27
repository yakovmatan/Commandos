using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Knife : IWeapon
    {
        public string MetalType { get; }
        public string Maker { get; }
        public string Color { get; }
        public int Weight { get; }

        public Knife(string metalType,string maker,string color,int weight)
        {
            this.MetalType = metalType;
            this.Maker = maker;
            this.Color = color;
            this.Weight = weight;
        }

        public void Shoot()
        {
            Console.WriteLine("*!Shhk*");
        }
    }
}
