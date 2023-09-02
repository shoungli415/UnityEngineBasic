/*
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
 * 더 작은 크기의 자료형으로 읽는 것은 명시하지 않으면 불가능(자료 손실이 일어나기 때문)
 */
namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}