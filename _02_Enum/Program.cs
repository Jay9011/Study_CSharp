namespace _02_Enum
{
    internal class Program
    {
        public enum DaysOfWeek
        {
            Sunday = 1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine($"{(DaysOfWeek)i} = {i}");
            }
        }
    }
}
