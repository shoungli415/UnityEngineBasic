using System.Security.Cryptography;

namespace Array
{
    internal class Program
    {
            // 2차원 배열
            // 아이템이 6개 있고 각 아이템은 5개의 서브 아이템을 가진다.
            // 6개의 행(row), 5개의 열(column)
            // 0 : 길
            // 1 : 벽
            // 2 : 도착지점
            // 3 : 플레이어

            static int[,] map = new int[6, 5]
            {
                {0, 0, 0, 0, 1},
                {0, 1, 1, 1, 1},
                {0, 0, 0, 1, 1},
                {1, 1, 0, 1, 1},
                {1, 1, 0, 1, 1},
                {1, 1, 0, 0, 2}
            };
            static int y, x;

        static void Main(string[] args)
        {
            #region 1차원 배열 및 반복문
            int[] arr = new int[5];
            arr[0] = 1;
            // [] 인덱서 : 인덱스 접근하기 위한 연산자
            // 0을 인덱스 : 인덱서에 몇 번째 인덱스에 접근할건지에 대한 입력
            // 배열의 인덱스 접근 :"배열 참조 주소로부터 + 인덱스 x 자료형 크기"부터 "자료형 크기"만큼 접근

            // 배열 만들 때 초기값을 명시하지 않으면 전부 default 값으로 초기화 됨.
            // 배열도 멤버 변수, 함수 등을 가지는 클래스 형태임.
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr[3]);
            Console.WriteLine(arr[4]);
            // Console.WriteLine(arr[5]); // 배열의 인덱스 범위는 0~Array.Length -1까지.

            //while (반복할 조건)
            //{
            //  반족할 내용
            //}

            int index = 0;
            while (index < arr.Length - 1)
            {
                Console.WriteLine(arr[index]);
                index++;


            }

            // do-while문 : 일단 한 번 수행하고 반복할지 말지 조건 체크
            //do
            //{
            //   반복할 내용 
            //} while(반복할 조건);

            // for (반복 시작 전 실행할 내용; 반복할 조건; 반복 수행 완료시마다 실행할 내용)
            //{
            //  
            //}
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            int[] arr2 = new int[8];
            System.Array.Copy(arr, arr2, arr.Length);

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = arr[i];
            }
            #endregion

            map[y, x] = 3;
            int goalY = 5;
            int goalX = 4;
            DrawMap();

            while (y != goalY || x != goalX)
            {
                string input = Console.ReadLine();
                input = input.ToUpper();
                if (input == "U") MoveDown();
                else if (input == "R") MoveRight();
                else if (input == "L") MoveLeft();
                else Console.WriteLine("잘못된 입력.");
            }

            Console.WriteLine("보물 찾기 끝!");
        }    

        static void DrawMap()
        {
            for (int i = 0; i < map.GetLength(0); i++) 
            { 
                for(int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 0)
                        Console.Write("□");
                    else if (map[i, j] == 1)
                        Console.Write("■");
                    else if (map[i, j] == 2)
                        Console.Write("☆");
                    else if (map[i, j] == 3)
                        Console.Write("▣");
                }
                Console.WriteLine();
            }
        }

        static void MoveUp() 
        {
            {
                //맵 범위 초과하는지 확인
                if (y <= map.GetLength(1) - 1)
                {
                    Console.WriteLine("해당 방향으로 움직일 수 없습니다. 맵의 경계를 초과합니다.");
                    return;
                }

                // 막혀있는지 확인
                if (map[y, x + 1] == 1)
                {
                    Console.WriteLine("벽으로 막혀있다.");
                    return;
                }

            }
        static void MoveDown() 
        { 

            
        }
        static void MoveLeft() 
        {
        
            //맵 범위 초과하는지 확인
            if (x <= map.GetLength(1) - 1)
            {
                Console.WriteLine("해당 방향으로 움직일 수 없습니다. 맵의 경계를 초과합니다.");
                return;
            }

               // 막혀있는지 확인
               if (map[y, x + 1] == 1)
               {
                   Console.WriteLine("벽으로 막혀있다.");
                   return;
         

            }
        static void MoveRight()
        {
            //맵 범위 초과하는지 확인
            if (x >= map.GetLength(1) - 1)
            {
                Console.WriteLine("해당 방향으로 움직일 수 없습니다. 맵의 경계를 초과합니다.");
                return;
            }

            // 막혀있는지 확인
            if (map[y, x+1] == 1) 
            {
                Console.WriteLine("벽으로 막혀있다.");
                return;
            }


            map[y, x] = 0;
            x++;
            map[y, x] = 3;
            DrawMap();
        }      
    }
}