using System.Runtime.CompilerServices;

namespace _07_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass myClass = new DerivedClass("외부에서 넣어준 description");
            myClass.PrintInfo();
        }
    }
}
