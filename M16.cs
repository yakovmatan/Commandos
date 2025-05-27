using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class M16 : Firearm, IWeapon
    {
        public M16():base("M16","COLT",29)
        { }

        public void Shoot()
        {
            Console.WriteLine("Boom");
            Ammocount--;
        }
    }
}
