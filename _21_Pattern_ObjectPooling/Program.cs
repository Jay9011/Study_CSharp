using System.Runtime.InteropServices;

namespace _21_Pattern_ObjectPooling
{
    public class MyObject: PoolObject
    {
        // MyObject에 추가할 필드나 메서드를 정의합니다.
        public string Name { get; set; }
    }
    internal class Program
    {
        private static readonly ObjectPool<MyObject> ObjectPool = new ObjectPool<MyObject>();

        static void Main(string[] args)
        {
            PrintObjectStatus();

            while (true)
            {
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.C)
                {
                    ActiveObject();
                }
                else if (key == ConsoleKey.Q) 
                {
                    break;
                }
            }
        }

        private static void ActiveObject()
        {
            var obj = ObjectPool.Use();
            if (obj != null)
            {
                PrintObjectStatus();

                Task.Run(async () =>
                {
                    await Task.Delay(2000);
                    DeactiveObject(obj);
                });
            }
            else
            {
                Console.WriteLine("\nObject pool is full.");
            }
        }

        private static void DeactiveObject(MyObject obj)
        {
            ObjectPool.Release(obj);
            PrintObjectStatus();
        }

        private static void PrintObjectStatus()
        {
            Console.Clear();
            Console.WriteLine("Press 'C' to create object, 'Q' to quit");
            Console.WriteLine($"Pool Size: {ObjectPool.Capacity}");
            Console.WriteLine($"Usable Objects: {ObjectPool.UsableCount}");
            Console.WriteLine("\nObject Pool Status:");
            for (int i = 0; i < ObjectPool.Count; i++)
            {
                PoolObject obj = ObjectPool.Get(i);
                Console.Write($"Object {obj.GetHashCode(), 10} is active: ");
                if (obj.IsActive)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.Write($"{obj.IsActive}");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
    }
}