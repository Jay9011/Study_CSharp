namespace _12_Delegate
{
    // public delegate bool ActionBtnDelegate();

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

            Player player = new Player();
            Stamina stamina = new Stamina();
            player.AddAction(stamina.UseStamina);

            Door door = new Door();
            player.AddAction(door.Open);
            player.OnAction();
            // 스태미너를 사용합니다.
            // 문을 엽니다.

            player.RemoveAction(door.Open);
            player.OnAction();
            // 스태미너를 사용합니다.
        }
    }
}
