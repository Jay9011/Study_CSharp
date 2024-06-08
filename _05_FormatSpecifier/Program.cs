namespace _05_FormatSpecifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2024년 5월 26일로 설정
            DateTime date = new DateTime(2024, 5, 26, 16, 23, 57);

            Console.WriteLine("d: {0:d}", date);
            Console.WriteLine("D: {0:D}", date);
            Console.WriteLine("t: {0:t}", date);
            Console.WriteLine("T: {0:T}", date);
            Console.WriteLine("f: {0:f}", date);
            Console.WriteLine("F: {0:F}", date);
            Console.WriteLine("g: {0:g}", date);
            Console.WriteLine("G: {0:G}", date);
            Console.WriteLine("m: {0:m}", date);
            Console.WriteLine("M: {0:M}", date);
            Console.WriteLine("o: {0:o}", date);
            Console.WriteLine("O: {0:O}", date);
            Console.WriteLine("r: {0:r}", date);
            Console.WriteLine("R: {0:R}", date);
            Console.WriteLine("s: {0:s}", date);
            Console.WriteLine("u: {0:u}", date);
            Console.WriteLine("U: {0:U}", date);
            Console.WriteLine("y: {0:y}", date);
            Console.WriteLine("Y: {0:Y}", date);

            Console.WriteLine("{0:%}", 0.35);
        }
    }
}
