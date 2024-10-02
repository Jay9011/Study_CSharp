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
        private static ObjectPool<MyObject> objectPool;

        static void Main(string[] args)
        {
            objectPool = new ObjectPool<MyObject>(10);

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
            var obj = objectPool.Use();
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
            objectPool.Release(obj);
            PrintObjectStatus();
        }

        private static void PrintObjectStatus()
        {
            Console.Clear();
            Console.WriteLine("Press 'C' to create object, 'Q' to quit");
            Console.WriteLine($"Pool Size: {objectPool.Capacity}");
            Console.WriteLine($"Usable Objects: {objectPool.InUseCount}");
            Console.WriteLine("\nObject Pool Status:");
            for (int i = 0; i < objectPool.Capacity; i++)
            {
                PoolObject obj = objectPool.Get(i);
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