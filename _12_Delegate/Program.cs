namespace _12_Delegate
{
    public delegate bool ActionBtnDelegate();

    class DelegateTest
    {
        public ActionBtnDelegate actionBtnDelegates;

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
            ActionBtnDelegate actionBtnDelegate1 = new ActionBtnDelegate(ActionBtn1);
            ActionBtnDelegate actionBtnDelegate2 = ActionBtn2;

            DelegateTest delegateTest = new DelegateTest();
            // delegateTest.SetActionDelegate(actionBtnDelegate1);
            // ActionBtnDelegate actionBtnDelegate = delegateTest.GetNowOperableDelegate();
            // if (actionBtnDelegate != null)
            // {
            //     Console.WriteLine($"Now Action : {actionBtnDelegate.ToString()}");
            //     // Now Action : _12_Delegate.ActionBtnDelegate
            // }
            // delegateTest.Action(); // ActionBtn1
            
            ActionBtnDelegate test = ActionBtn1;
            test = test + ActionBtn2; // test += ActionBtn2;
            test();
            // ActionBtn1
            // ActionBtn2
        }
    }
}
