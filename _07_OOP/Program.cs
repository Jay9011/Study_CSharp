namespace _07_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass1 = new MyClass();
            myClass1.Value = 1;
            myClass1.Name = "MyClass1";

            MyClass myClass2 = new MyClass();
            myClass2.Value = 1;
            myClass2.Name = "MyClass2";

            Console.WriteLine(myClass1.Equals(myClass2)); // True
        }
    }
}
