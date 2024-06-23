namespace _13_Lambda
{
    internal class Program
    {
        static void ActionTest(Action action)
        {
            action();
        }
        static void FuncTest<T>(Func<T, T, bool> func, T a, T b)
        {
            if (func(a, b))
            {
                Console.WriteLine("Func Test True");
            }
            else
            {
                Console.WriteLine("Func Test False");
            }
                
        }
        static void Main(string[] args)
        {
            // 매개변수가 없는 식람다
            ActionTest(   () => Console.WriteLine("ActionTest")   ); // 결과: ActionTest

            // 매개변수가 있는 식람다
            FuncTest(   (int a, int b) => a > b   , 1, 2); // 결과: Func Test False

            // 매개변수가 없는 문람다
            Action action = () =>
            {
                Console.WriteLine("Statement Lambda");
                Console.WriteLine("ActionTest");
            };
            ActionTest(action); // 결과: Statement Lambda\r\n ActionTest

            // 매개변수가 있는 문람다
            Func<int, int, bool> func = (a, b) =>
            {
                if (a > b)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            };
            FuncTest(func, 1, 2); // 결과: Func Test True
        }
    }
}
