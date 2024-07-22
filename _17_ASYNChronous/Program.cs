namespace _17_ASYNChronous
{
    internal class Program
    {
        public static async Task ExampleMethodAsync()
        {
            // 이 부분은 동기적으로 실행됩니다.
            Console.WriteLine("2. Before await");

            // 비동기 작업을 기다립니다.
            await Task.Delay(1000);

            // 이 부분은 비동기 작업이 완료된 후에 실행됩니다.
            Console.WriteLine("6. After await");
        }

        public static async Task CallExampleMethod()
        {
            // ExampleMethodAsync()를 호출하면 즉시 Task를 반환합니다.
            Task task = ExampleMethodAsync();

            Console.WriteLine("3. ExampleMethodAsync 호출 됨");

            await task;  // 비동기 작업이 완료될 때까지 기다립니다.
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("1. Main 실행 됨.");

            await CallExampleMethod();

            Console.WriteLine("4. CallExampleMethod 호출 됨.");

            Console.WriteLine("5. Main 종료 됨.");
        }
    }
}

