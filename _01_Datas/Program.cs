namespace _01_Datas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int? nullableInt = 5;
            // double? nullableDouble = 3.14;
            // bool? nullableBool = null;
            //
            // Console.WriteLine($"NullableDouble: {nullableDouble.Value}");   // NullableDouble: 3.14
            // if (nullableBool == null)
            // {
            //     Console.WriteLine("Null");
            // }
            //
            // if (nullableInt.HasValue)
            // {
            //     Console.WriteLine($"Value: {nullableInt.Value}");
            // }
            // else
            // {
            //     Console.WriteLine("No value");
            // }



            int? nullableInt = null;
            int defaultValue = nullableInt ?? -1; // nullableInt가 null이면 -1을 사용
            Console.WriteLine(defaultValue); // 출력: -1


            int? length = nullableInt?.ToString().Length;
            Console.WriteLine(length); // nullableInt가 null이면 length도 null

        }
    }
}