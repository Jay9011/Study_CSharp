namespace _06_Class
{
    public class MyClass
    {
        public int Value;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // int number = 10;
            // Console.WriteLine($"Before: {number}"); // Before: 10
            //
            // CallByValue(number);
            // Console.WriteLine($"Value After: {number}");  // Value After: 10
            //
            // CallByReference(ref number);
            // Console.WriteLine($"Ref After: {number}");  // Ref After: 20

            MyClass myClass = new MyClass();
            myClass.Value = 10;
            Console.WriteLine($"Before: {myClass.Value}"); // Before: 10

            ModifyObject(myClass);
            Console.WriteLine($"ModifyObject: {myClass.Value}");    // ModifyObject: 20

            ReplaceObject(myClass);
            Console.WriteLine($"ReplaceObject: {myClass.Value}");   // ReplaceObject: 20

            ReplaceObject(ref myClass);
            Console.WriteLine($"ReplaceObject With ref: {myClass.Value}");  // ReplaceObject With ref: 30
        }

        public static void CallByValue(int value)
        {
            value = 20;
        }
        public static void CallByReference(ref int value)
        {
            value = 20;
        }
        public static void ModifyObject(MyClass myClass)
        {
            myClass.Value = 20;
        }
        public static void ReplaceObject(MyClass myClass)
        {
            myClass = new MyClass();
            myClass.Value = 30;
        }
        public static void ReplaceObject(ref MyClass myClass)
        {
            myClass = new MyClass();
            myClass.Value = 30;
        }
    }
}
