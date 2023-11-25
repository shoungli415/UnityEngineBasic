using System.Threading.Channels;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //if문
            int number = 25;
            bool isPair;

            if ((number % 2) == 0) 
            {
                isPair = true;
            }
            else
            {
                isPair = false;
            }
            Console.WriteLine(isPair);

            // 삼항연산자
            bool isPair2 = ((number % 2) == 0 ? true : false);

            Console.WriteLine(isPair2);
        }
    }
}