using System.Collections;

namespace _18_yield
{
    // 상태 기계 예시
    public class GetNumbersEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new GetNumbersEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static IEnumerable<int> Create()
        {
            return new GetNumbersEnumerable();
        }
    }

    public class GetNumbersEnumerator : IEnumerator<int>
    {
        private int state = 0;
        private int current;

        public int Current => current;

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            switch (state)
            {
                case 0:
                    current = 1;
                    state = 1;
                    return true;
                case 1:
                    current = 2;
                    state = 2;
                    return true;
                case 2:
                    current = 3;
                    state = -1;  // End of enumeration
                    return true;
                default:
                    return false;
            }
        }

        public void Reset()
        {
            state = 0;
        }

        public void Dispose() { }
    }

    public static class Example01
    {
        public static IEnumerable<int> GetNumbers()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
        public static void Example()
        {
            foreach (var number in GetNumbers())
            {
                Console.WriteLine(number);  // 출력: 1, 2, 3
            }
        }
    }

    public static class Example02
    {
        public static void Example()
        {
            foreach (var number in GetNumbersEnumerable.Create())
            {
                Console.WriteLine(number);  // 출력: 1, 2, 3
            }
        }
    }

    internal class Program
    {
        public static IEnumerable<int> Fibonacci(int count)
        {
            int previous = 0, current = 1;

            for (int i = 0; i < count; i++)
            {
                yield return previous;

                int next = previous + current;
                previous = current;
                current = next;
            }
        }
        static void Main(string[] args)
        {
            foreach (var number in Fibonacci(10))
            {
                Console.WriteLine(number);
            }
        }
    }
}