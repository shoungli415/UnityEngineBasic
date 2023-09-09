﻿/*
 * int : 부호가 있는 정수형(4byte)
 * long : 부호가 있는 정수형(8byte)
 * uint : 부호가 없는 정수형(4byte)
 * ulong : 부호가 없는 정수형(8byte)
 * short : 부호가 있는 정수형(2byte)
 * ushort : 부호가 있는 정수형(2byte)
 * 
 * 2의 보수 : 모든 비트 반전 후 +1
 * 
 * char : 문자형(2byte) - ASCII 코드표에 따름
 * float : 실수형(4byte) 
 * double : 실수형(8byte)
 * bool : 논리형(1byte)(0이면 거짓, 0이 아니면 참)
 * 
 * 어떤 자료형을 더 큰 동일 형태의 자료형으로 읽는 것은 가능(자료형의 승격), 이때 암시적 형변환이 일어남.
 * 더 작은 크기의 자료형으로 읽는 것은 명시하지 않으면 불가능(자료 손실이 일어나기 때문)*/
namespace FirstProject
{
    // 철수 객체 할당할 때 필요한 메모리 : 8 byte (멤버 변수 크기 총합)
    class 철수
    {
        uint 나이;
        int 돈;
    }

    // 영희 객체 할당할 때 필요한 메모리 : 4(float) + 4(int) = 8 byte
    class 영희
    {
        float 키; 
        // 전역변수 : 어디서나 접근 가능한 변수
        // 클래스의 멤버 변수도 전역변수임. 
        public int 나이 = 1; // 변수 선언 부분에 어떤 값을 대입하겠다는 대인 연산을 쓰면
                    // 해당 값을 초기 데이터로 쓰겠다는 명시 (Data 영역에 할당)

        // 정적 : 동적의 반대 의미. 동적으로 할당할 수 없다. 
        //, 런타임 중에 메모리에 추가적인 할당이 불가능하다.
        static char 성별 = '여';

        // 접근제한자 (Access Modigier)
        // 외부에서의 멤버 접근 가능 여부를 제한하는 키워드
        // private - 이 클래스 말고 다른 클래스는 해당 멤버에 접근할 수 없다.
        // protected - 이 클래스를 상속 받은 자식 클래스까지만 해당 멤버에 접근할 수 있다.
        // internal - Assembly(코드조각 exe, dll 등) 단위로만 해당 멤버에 접근할 수 있다.
        // public - 접근 제한 없음.

        //클래스는 캡슐화를 컨셉으로 한 사용자 정의 자료형임.
        // -> 접근 제한자를 명시하지 않으면 외부 접근을 차단하는게(private) 기본 컨셉.


        // 클래스 생성자
        // 힙메모리 영역에 클래스타입의 객체를 할당
        // 멤버변수의 초기화를 진행
        // 생성된 객체의 주소를 반환.
        public 영희()
        {

        }

        // 클래스 소멸자
        // 해당 객체가 할당된 메모리 영역을 시스템에 반환하는 함수
        // 가비지컬렉터가 알아서 소멸시키기 때문에 직접 호출할 일은 없음
        ~영희()
        {

        }

        // void : 타입 정해지지 않음 (반환타입 없음)
        void SayMyAge()
        {
            // todo -> 이름 출력하기
        }

        // 지역변수 : { } 내에서 정의되어 해당 연산 중에만 메모리에 할당되는 변수
        // 파라미터도 지역변수의 일종

        // 인스턴스 멤버 함수는 데이터를 참조할 목표 객체에 대한 참조 파라미터가 생략되어 있음.
        // -> this 키워드로 해당 목표객체 참조가 가능함.
        // -> this 키워드도 생략 가능함.

        //public bool 나이먹기(영희 목표개체, int 먹을나이) <- 원래 이렇게 생김
        public bool 나이먹기(int 먹을나이)
        {
            int 예상나이 = this.나이 + 먹을나이;
            // if 구문 :
            // if (논리형의 실행조건)
            // {
            //      실행조건이 참일 때 실행할 내용
            // }
            //else
            //{
            //      실행조건이 거짓일 때 실행할 내용
            //}

            // 만약 예상나이가 음수면 나이 못먹는다고 할거임.

            if (예상나이 < 0)
            {
                return false;
            }
            else
            {
                나이 = 예상나이;
                return true;
            }
        }
    }

    internal class Program
    {
        // 변수
        // : 아직 정해지지 않은 값.

        // 멤버 변수
        // 사용자 정의 자료형에서 특정 공간을 구성하는 구성원으로 정의된 변수
        int a;
        uint b;
        short c;
        ushort d;
        long e;
        ulong f;
        char g;
        float h;
        double i;
        bool j;

        // 메인함수, 프로그램 실행시 처음 호출되는 (실행되는) 함수.
        static void Main(string[] args)
        {
            // . 멤버 접근 연산자
            Console.WriteLine("Hello, World!");

            // 값 타입 vs 참조 타입
            // 값 타입 : 데이터를 직접 메모리에 쓰고 읽는 타입
            // 참조 타입 : 특정 메모리 주소를 통해 간 접적으로 해당 메모리에 데이터를 쓰고 읽는 타입
            // 포인터 타입 : 메모리 주소를 쓰고 읽는 타입 (C#에서는 unsafe 코드 작성 외에 쓰지 않음)
            int a;
            // new : 동적할당 키워드(메모리를 동적으로 할당하겠다고 명시하는 키워드)
            // 객체 주소 참조 변수
            영희 영희1 = new 영희(); // 영희 객체 만들고 영희가 있는 주소를 영희1이라는 변수에 저장
            영희 영희2 = new 영희();
            Console.WriteLine(영희1.나이먹기(1));
            Console.WriteLine(영희1.나이);
            Console.WriteLine(영희2.나이);
        }
    }
}