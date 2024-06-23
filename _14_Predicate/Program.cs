namespace _14_Predicate
{
    static class Utilities
    {
        public static int Count<T>(IEnumerable<T> items, Predicate<T> predMethod)
        {
            int count = 0;
            foreach (var item in items)
            {
                if (predMethod(item))
                {
                    count++;
                }
            }
            return count;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            Console.WriteLine(Utilities.Count(numbers, n => n % 2 != 0)); // 5
            Console.WriteLine(Utilities.Count(numbers, n => n % 2 == 0)); // 4

            var result = numbers.FindAll(n => n % 2 == 0);
            Console.WriteLine(string.Join(", ", result)); // 2, 4, 6, 8
        }
    }
}
