namespace _07_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass myClass = new DerivedClass();
            myClass.PrintInfo();    // Name: DerivedClass, Value: 1, Description: 파생 클래스만의 멤버

            myClass.Name = "MyClass";
            Console.WriteLine($"Class Name: {myClass.Name}");   // Class Name: MyClass

            // myClass.value = 10; // 접근 제한자로 인해 set 불가
            Console.WriteLine($"Class Value: {myClass.value}");
        }
    }
}
