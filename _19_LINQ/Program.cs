namespace _19_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 예제: 정수 배열에서 짝수를 선택하는 LINQ 쿼리
            int[] numbers = [1, 2, 3, 4, 5, 6];
            
            // 쿼리 구문
            var evenNumbers = from num in numbers
                where num % 2 == 0
                select num;

            // 메서드 구문
            var evenNumbers2 = numbers.Where(num => num % 2 == 0);

            // 결과 출력
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            
            foreach (var num in evenNumbers2)
            {
                Console.WriteLine(num);
            }
        }
    }
}