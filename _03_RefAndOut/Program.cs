namespace _03_RefAndOut
{
    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Add(int a, int b, out int result)
        {
            result = a + b;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;

            Swap(ref num1, ref num2);
        }
    }
}
