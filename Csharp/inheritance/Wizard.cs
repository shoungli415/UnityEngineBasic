using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Wizard : PlayableCharacter
    {
        public override void Breathe()
        {
            base.Breathe();
        }
        public override void Move()
        {
            Console.WriteLine("Move");
        }

        public void Fireball()
        {
            Console.WriteLine("Fireball");
        }
    }
}
