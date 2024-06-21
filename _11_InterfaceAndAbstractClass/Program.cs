namespace _11_InterfaceAndAbstractClass
{
    public interface IMyInterface
    {
        void MyMethod();
        void MyMethod2()
        {
            Console.WriteLine("기본 구현 제공");
        }
        string MyProperty { get; set; }
        delegate void MyDelegate();
        event MyDelegate MyEvent;
        int this[int index] { get; set; }
    }
    public abstract class MyAbstractClass
    {
        public int index;
        public abstract void MyMethod();
    }
    public class MyClass : IMyInterface
    {
        private char[] txtNumber;

        public MyClass(int number)
        {
            txtNumber = number.ToString().ToCharArray();
        }

        public void MyMethod()
        {
            Console.WriteLine("MyMethod");
        }
        public string MyProperty { get; set; }
        public event IMyInterface.MyDelegate MyEvent;
        public int this[int index]
        {
            get { return int.Parse(txtNumber[index].ToString()); }
            set { txtNumber[index] = value.ToString()[0]; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass(123);
            myClass.MyMethod2();
        }
    }
}
