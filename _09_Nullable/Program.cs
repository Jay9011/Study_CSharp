namespace _09_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;

            if (i == null)
            {
                Console.WriteLine("int i 가 null 입니다.");
            }

            int? nullableInt = null;
            double? nullableDouble = null;
            bool? nullableBool = null;


            // int num1 = nullableInt; // 암시적으로 'int?' 형식을 'int' 형식으로 변환할 수 없습니다.
            int num2 = nullableInt.GetValueOrDefault();

            string? nullableStr = null;
            Console.WriteLine($"str : {nullableStr ?? "Null"}");    // str : Null

            if (nullableStr != null && nullableStr.Length > 0)
            {
                Console.WriteLine("nullableStr.Length > 0");
            }

            int? length = nullableStr?.Length;  // nullableStr이 null이면 null을 반환
            Console.WriteLine($"length : {length}");    // length :
            Console.WriteLine($"length?? : {length ?? -1}"); // length?? : -1
        }
    }
}
