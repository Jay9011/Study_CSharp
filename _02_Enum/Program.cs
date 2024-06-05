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
            // for (int i = 1; i <= 7; i++)
            // {
            //     Console.WriteLine($"{(DaysOfWeek)i} = {i}");
            // }

            // 문자열을 열거형으로 변환
            string dayString = "Friday";
            DaysOfWeek day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), dayString);
            Console.WriteLine(day); // 출력: Friday

            // 열거형의 모든 값 가져오기
            DaysOfWeek[] days = (DaysOfWeek[])Enum.GetValues(typeof(DaysOfWeek));
            foreach (DaysOfWeek d in days)
            {
                Console.WriteLine(d);
            }

            // 열거형의 모든 이름 가져오기
            string[] dayNames = Enum.GetNames(typeof(DaysOfWeek));
            foreach (string name in dayNames)
            {
                Console.WriteLine(name);
            }


            // DaysOfWeek input = (DaysOfWeek)Convert.ToInt32(Console.ReadLine());
            //
            // switch (input)
            // {
            //     case DaysOfWeek.Sunday:
            //         Console.WriteLine("일요일");
            //         break;
            //     case DaysOfWeek.Monday:
            //         Console.WriteLine("월요일");
            //         break;
            //     case DaysOfWeek.Tuesday:
            //         Console.WriteLine("화요일");
            //         break;
            //     case DaysOfWeek.Wednesday:
            //         Console.WriteLine("수요일");
            //         break;
            //     case DaysOfWeek.Thursday:
            //         Console.WriteLine("목요일");
            //         break;
            //     case DaysOfWeek.Friday:
            //         Console.WriteLine("금요일");
            //         break;
            //     case DaysOfWeek.Saturday:
            //         Console.WriteLine("토요일");
            //         break;
            //     default:
            //         Console.WriteLine("잘못된 입력");
            //         break;
            // }
        }
    }
}
