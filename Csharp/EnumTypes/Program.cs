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
            foreach (var item in array) 
            {
                Console.WriteLine(item);
            
            }
        }
    }
}