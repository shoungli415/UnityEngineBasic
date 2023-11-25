namespace 반복문
{
    internal class for문
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++) 
            {
                if ((i%3) != 0)
                {
                    continue;
                }Console.WriteLine($"3으로 나뉘는 숫자 발견 : {i}");
            }
        }
    }
}