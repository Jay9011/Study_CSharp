namespace _04_Function
{
    internal static class OptionalParam
    {
        public static void PrintMessage(string message, int repeatCount = 1)
        {
            for (int i = 0; i < repeatCount; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
