using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _07_OOP
{
    public static class MathUtilities
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class StaticClass
    {
        public static int counter = 0;
        public string Name;

        static StaticClass()
        {
            Console.WriteLine("Static constructor");
        }

        public static void IncrementCounter()
        {
            counter++;
            // this.Name = "Name" // this 키워드를 사용할 수 없다.
        }

        public void Print()
        {
            this.Name = "Name"; // this 키워드를 사용하여 인스턴스 멤버에 접근할 수 있다.
            Console.WriteLine($"Name: {Name}, counter: {counter}"); // static 멤버에도 접근 가능
        }
    }
}
