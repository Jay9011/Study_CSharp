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
            if (false)
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

            if (true)
            {
                int capture = 10;

                // 람다식을 사용한 클로저
                Action<int> AddTest = x => capture += x;
                AddTest(5);
                Console.WriteLine(capture); // 결과: 15

                Func<int, int> multiplier = CreateMultiplier(2);
                // 즉, 람다가 생성될 때의 a의 값이 2로 고정됨
                Console.WriteLine(multiplier(10)); // 결과: 20
            }
        }

        static Func<int, int> CreateMultiplier(int a)
        {
            // 반환 값으로 람다식을 사용
            // 이때, a는 람다식 외부의 변수 a를 참조하고 있으므로 클로저가 생성됨
            return x => a * x;
        }
    }
}
