namespace _12_Delegate
{
    // public delegate bool ActionBtnDelegate();

    // public delegate bool Predicate<T>(T x);

    class TestClass
    {
        private Action ActionDelegate;
        private Func<int, int, int> AddDelegate;
        public void AddAction(Action action)
        {
            ActionDelegate += action;
        }
        public void OnAction()
        {
            ActionDelegate?.Invoke();
        }
    }

    static class Utilities
    {
        public static int Count<T>(IEnumerable<T> items, Func<T, bool> predMethod)
        {
            int count = 0;
            foreach (var item in items)
            {
                if (predMethod(item))
                {
                    count++;
                }
            }
            return count;
        }
    }

    class DelegateTest
    {
        private ActionBtnDelegate actionBtnDelegates;

        public ActionBtnDelegate GetNowOperableDelegate()
        {
            return actionBtnDelegates;
        }
        public void SetActionDelegate(ActionBtnDelegate actionBtnDelegate)
        {
            actionBtnDelegates = actionBtnDelegate;
        }
        public void Action()
        {
            if (actionBtnDelegates != null)
            {
                actionBtnDelegates();
            }
            else
            {
                Console.WriteLine("등록된 델리게이트가 없습니다.");
            }
        }
    }
    class EventTest
    {
        public event EventHandler actionBtnDelegates;

        public void Action()
        {
            actionBtnDelegates?.Invoke(this, EventArgs.Empty);
        }
    }

    internal class Program
    {
        private static bool ActionBtn1()
        {
            Console.WriteLine("ActionBtn1");
            return true;
        }
        private static bool ActionBtn2() {
            Console.WriteLine("ActionBtn2");
            return true;
        }

        private static void ActionTest()
        {
            Console.WriteLine("ActionTest");
        }
        private static int AddTest(int x, int y)
        {
            return x + y;
        }
        
        static void Main(string[] args)
        {
            // ActionBtnDelegate actionBtnDelegate1 = new ActionBtnDelegate(ActionBtn1);
            // ActionBtnDelegate actionBtnDelegate2 = ActionBtn2;
            //
            // DelegateTest delegateTest = new DelegateTest();
            // delegateTest.SetActionDelegate(actionBtnDelegate1);
            // ActionBtnDelegate actionBtnDelegate = delegateTest.GetNowOperableDelegate();
            // if (actionBtnDelegate != null)
            // {
            //     Console.WriteLine($"Now Action : {actionBtnDelegate.ToString()}");
            //     // Now Action : _12_Delegate.ActionBtnDelegate
            // }
            // delegateTest.Action(); // ActionBtn1
            //
            // ActionBtnDelegate test = ActionBtn1;
            // test = test + ActionBtn2; // test += ActionBtn2;
            // test();
            // // ActionBtn1
            // // ActionBtn2

            // Player player = new Player();
            // Item item = new Item();
            // player.actionBtnDelegates = item.PickUp;
            // player.OnAction(); // 아이템을 줍습니다.
            //
            // Door door = new Door();
            // player.actionBtnDelegates = door.Open;
            // player.OnAction(); // 문을 엽니다.
            //
            // Enemy enemy = new Enemy();
            // player.actionBtnDelegates = enemy.StealthKill;
            // player.OnAction(); // 암살을 합니다.

            // Item item = new Item();
            // player.actionBtnDelegates = item.PickUp;
            // player.actionBtnDelegates.Invoke(); // 아이템을 줍습니다.

            // Player player = new Player();
            // Stamina stamina = new Stamina();
            // player.AddAction(stamina.UseStamina);
            //
            // Door door = new Door();
            // player.AddAction(door.Open);
            // player.OnAction();
            // // 스태미너를 사용합니다.
            // // 문을 엽니다.
            //
            // player.RemoveAction(door.Open);
            // player.OnAction();
            // // 스태미너를 사용합니다.

            // PlayerWEvent playerWEvent = new PlayerWEvent();
            //
            // DoorWArgs door = new DoorWArgs();
            // playerWEvent.actionBtnDelegates += door.Open;
            //
            // playerWEvent.Action();
            // // 스태미너를 사용합니다.
            // // 문을 엽니다.
            //     
            // playerWEvent.Action();
            // // 스태미너를 사용합니다.
            // // 스태미너가 부족합니다.

            var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};

            int oddNumbers = Utilities.Count(numbers, delegate(int n) { return n % 2 != 0; });
            Console.WriteLine(oddNumbers); // 5

            int evenNumbers = Utilities.Count(numbers, delegate(int n) { return n % 2 == 0; });
            Console.WriteLine(evenNumbers); // 4

            Func<int, int, int> add = delegate(int x, int y) { return x + y; };
            Console.WriteLine( add(3, 4) ); // 7

            Action<int> print = delegate(int x) { Console.WriteLine(x); };
            print(10); // 10


            TestClass testClass = new TestClass();
            testClass.AddAction(ActionTest);
            testClass.OnAction(); // ActionTest
        }
    }
}
