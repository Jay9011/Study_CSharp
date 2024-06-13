using System.Runtime.CompilerServices;

namespace _07_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = StaticClass.counter;  // 출력: Static constructor
            StaticClass C1 = new StaticClass(); // 출력 없음
        }
    }
}
