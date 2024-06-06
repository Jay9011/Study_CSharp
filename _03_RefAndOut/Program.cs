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

        static int Divide(int a, int b, out int remainder)
        {
            remainder = a % b;
            return a / b;
        }

        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 3;

            int remain = 0;
            int quot = Divide(num1, num2, out remain);

            Console.WriteLine($"{num1} / {num2} = {quot} ({remain})");
        }
    }
}
