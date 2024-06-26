namespace _16_ExtensionMethod
{
    // class NewString : String    // sealed 형식 'string'에서 파생될 수 없습니다.
    // {
    //
    // }

    static class ExtendString
    {
        public static void CustomMethod(this string str)
        {
            Console.WriteLine($"Custom: {str}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            "Hello".CustomMethod(); // Custom: Hello
        }
    }
}
