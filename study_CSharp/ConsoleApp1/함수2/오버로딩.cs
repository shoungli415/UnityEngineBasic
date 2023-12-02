using System;
using System.Diagnostics.CodeAnalysis;

namespace 함수2
{
    class 오버로딩
    {
        static int Factorial(int n)
        {
            //int ret = 1;

            //for (int num = 1; num <= n; num++)
            //{
            //    ret *= num;
            //}
            //return ret;

            if (n <=1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            // 구구단
            //for (int i = 2; i < 10; i++)
            //{
            //    for(int a=1; a < 10; a++)
            //    {
            //        Console.WriteLine($"{i} * {a} = {i*a}");
            //    }
            //}

            // 별 찍기
            //string a = "*";
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{a}\n");
            //    a = a + "*";
            //}

            //팩토리얼 만들기
            int ret = Factorial(5);
            Console.WriteLine(ret);
            
        }
    }                   
}