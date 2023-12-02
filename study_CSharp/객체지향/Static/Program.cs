namespace Static
{
    class Knight
    {
        // 필드
        static public int counter = 1; // 오로지 1개만 존재

        public int id;
        public int hp;
        public int attack;

        static public void Test()
        {
            counter++;
        }

        static public Knight CreateKnight()
        {
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 1;
            return knight;
        }

        public Knight()
        {
            id = counter;
            counter++;

            hp = 100;
            attack = 10;
            Console.WriteLine("생성자 호출!");
        }

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }

        public void Move()
        {
            Console.WriteLine("Knight Move");
        }

        public void Attack()
        {
            Console.WriteLine("Knight Attack");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();

            Knight knight2 = new Knight();
            knight2.hp = 80;

            Knight knight3 = new Knight();
            knight3.hp = 200;
        }
    }
}