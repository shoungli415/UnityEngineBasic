namespace EnumTypes
{
    // enum 사용자 정의 자료형 (열거형)
    // 정수값에 대한 이름 목록을 작성할 수 있음.
    // 기본적으로는 nint 데이터와 같이 생김.
    public enum State
    {
        None,
        Idle,
        Move,
        Jump,
        Fall,
        Attack = 20
    }

    // 열거형으로 Bit Flags를 정의하는 방법
    public enum LayerMask
    {
        Default = 0 << 0, // 0
        Ground = 1 << 0,  // 1
        Player = 1 << 1,  // 2  
        Enemy = 1 << 2,   // 4  
    }

    class Player
    {
        // const 상수 키워드
        // 해당 변수를 상수로서 사용하겠다고 명시하는 키워드.
        // 상수 취급이므로 런타임 중에 값을 대입할 수 없다.
        public const int STATE_JUMP = 3;

        // 1 : Idle.
        // 2 : Move.
        // 3 : Jump.
        // 4 : Fall.
        //public int state;
        public State state;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            //player.state = 3; // Magic Number 쓰지말자
            //player.state = Player.STATE_JUMP;
            player.state = State.Jump;

            // Enum 클래스 : 열거형 타입에 대한 편의 기능들을 제공하는 클래스
            // Type 클래스 : 어떤 타입을 대표하는 정보를 가질 수 있는 클래스
            // 어떤 타입을 Type 클래스 타입으로 반환 받고 싶으면 typeof(타입)라는 키워드를 쓸 수 있다.
            // Array 클래스 : 배열에 대한 편의 기능들을 제공하는 클래스
            Array array = Enum.GetValues(typeof(State));

            // in 뒤의 있는 것을 차례대로 순회하면서 현재 순회 중인 아이템을 반환하는 구문인거 같은데..?
            foreach (var item in array) 
            {
                Console.WriteLine(item);
            
            }

            // switch-case 구문
            // break: 현재 구문을 탈출
            // continue: 현재 라인에서 코드 흐름 끊고 다시 현재 구문 처음으로 돌아가서 실행
            // return: 현재 할당된 함수를 종료하고 메모리 해제
            /*switch (변수)
            {
                case 값1:
                    break;
                case 값2:
                    {
                        변수가 값1 또는 값2일 떄 실행할 내용
                    }
                    break;
                default: 
                    break;
            }*/

            switch (player.state)
            {
                case State.None:
                    break;
                case State.Idle:
                    {
                        // something to do when player is idle
                    }
                    break;
                case State.Move:
                    break;
                case State.Jump:
                case State.Fall:
                    {
                        //something to do when player is Jump Fall
                    }
                    break;
                case State.Attack:
                    break;
                default:
                    break;
            }

            string names = string.Empty;
            switch (names)
            {
                case "철수":
                    break;
                case "영희":
                    break;
                default:
                    break;
            }

            int colliderLayer = 3;
            int colliderMask = 1 << 1 | 1 << 2;
            if((1 << colliderLayer & colliderMask) > 0) 
            { 
            
            }

            LayerMask mask = LayerMask.Player | LayerMask.Enemy;
            if((1 << colliderLayer & (uint)mask) > 0)
            {

            }
        }
    }
}