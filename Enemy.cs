using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Enemy
    {
        public string Name { get; }
        public int Life { get; private set; } = 100;
        public bool IsLife { get; set; } = true;

        public Enemy(string name)
        {
            this.Name = name;
        }

        public void Hit()
        {
            this.Life -= 10;
            IfDead();
        }

        public void IfDead()
        {
            if(this.Life <= 0)
            {
                this.IsLife = false;
            }    
        }

        public void Shout()
        {
            Console.WriteLine("i'm enemy");
        }
    }
}
