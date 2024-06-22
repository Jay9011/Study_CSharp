using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Delegate
{
    internal class MyEventArgs : EventArgs
    {
        public MyEventArgs(int n)
        {
            RemainStamina = n;
        }
        public int RemainStamina { get; set; }
    }
    internal class PlayerWEvent
    {
        public event EventHandler<MyEventArgs> actionBtnDelegates;

        private StaminaWArgs stamina;

        public PlayerWEvent()
        {
            stamina = new StaminaWArgs();
            actionBtnDelegates += stamina.UseStamina;
        }

        public void Action()
        {
            actionBtnDelegates?.Invoke(this, new MyEventArgs(stamina.NowStamina));
        }
    }
    internal class StaminaWArgs
    {
        public int NowStamina { get; set; } = 10;
        public void UseStamina(object? sender, MyEventArgs e)
        {
            NowStamina -= 10;
            Console.WriteLine("스태미너를 사용합니다.");
        }
    }
    internal class DoorWArgs
    {
        public void Open(object? sender, MyEventArgs e)
        {
            if (e.RemainStamina < 10)
            {
                Console.WriteLine("스태미너가 부족합니다.");
                return;
            }
            Console.WriteLine("문을 엽니다.");
            return;
        }
    }
}
