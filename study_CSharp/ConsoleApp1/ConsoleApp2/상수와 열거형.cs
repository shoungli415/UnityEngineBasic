namespace ConsoleApp2
{
    class Program
    {
        enum Choice
        {
            ROCK,
            PAPER,
            SCISSORS
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); // 0~2 사이의 랜덤 값
            int choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case (int)Choice.ROCK:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case (int)Choice.PAPER:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
                case (int)Choice.SCISSORS:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
            }

            switch (aiChoice)
            {
                case (int)Choice.ROCK:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다.");
                    break;
                case (int)Choice.PAPER:
                    Console.WriteLine("컴퓨터의 선택은 보입니다.");
                    break;
                case (int)Choice.SCISSORS:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                    break;
            }

            //if (choice == 0)
            //{
            //    if (aiChoice == 0)
            //    {
            //        Console.WriteLine("Same score!");
            //    }
            //    else if (aiChoice == 1)
            //    {
            //        Console.WriteLine("You lose");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You win!");
            //    }
            //}

            //else if (choice == 1)
            //{
            //    if (aiChoice == 0)
            //    {
            //        Console.WriteLine("You win!");
            //    }
            //    else if (aiChoice == 1)
            //    {
            //        Console.WriteLine("Same score!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You lose");
            //    }
            //}

            //else
            //{
            //    if (aiChoice == 0)
            //    {
            //        Console.WriteLine("You lose");
            //    }
            //    else if (aiChoice == 1)
            //    {
            //        Console.WriteLine("You win!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Same score!");
            //    }
            //}

            if (choice == aiChoice)
            {
                Console.WriteLine("무승부");
            }
            else if ((choice == 0 && aiChoice == 2) || (choice == 1 && aiChoice == 0) || (choice == 2 && aiChoice == 1))
            {
                Console.WriteLine("승리");
            }
            else 
            {
                Console.WriteLine("패배");
            }


        }
    }
}