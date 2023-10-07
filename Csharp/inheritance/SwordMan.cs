using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    private int _swordMan_swordMasteryLevel;
    internal class SwordMan : PlayableCharacter
    {
        // override : 재정의 키워드
        // 기반타입의 멤버를 재정의 할때 사용하는 키워드
        public override void Move()
        {
            Console.WriteLine("Move");
        }

        public void Smash()
        {
            Console.WriteLine("Smash");
        }
    }
}