using System.ComponentModel;

namespace 함수
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        //static void AddOne(ref int number)
        //{
        //    number += 1;
        //}


        //static void AddOne2(out int number)
        //{
        //    number = 1;
        //}

        static void Divide(int a, int b, out int result1, out int result2)
        {
            result1 = a / b;
            result2 = a % b;

        }
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            Program.Swap(ref num1, ref num2);
            Console.WriteLine($"{num1} {num2}");

            int c;
            int d;
            Divide(10, 3, out c, out d);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }    
    }
}