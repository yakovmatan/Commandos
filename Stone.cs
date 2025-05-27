using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Stone : IWeapon
    {
        public int Weight { get; }
        public string Color { get; }
        public bool IsComplete { get; private set; } = true;

        public int HitsToBreak { get; } = 5;
        public int CurrentHits { get; private set; } = 0;


        public Stone(int weight,string color)
        {
            this.Weight = weight;
            this.Color = color;
        }

        public void Shoot()
        {
            Console.WriteLine("Boom");
            this.CurrentHits++;
            this.TryBreak();
        }

        public void TryBreak()
        {
            if (CurrentHits == HitsToBreak)
            {
                this.IsComplete = false;
            }
        }
    }
}
