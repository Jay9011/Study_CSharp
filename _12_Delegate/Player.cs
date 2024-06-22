using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Delegate
{
    public delegate bool ActionBtnDelegate();

    internal class Player
    {
        private ActionBtnDelegate actionBtnDelegates;

        public void AddAction(ActionBtnDelegate actionBtnDelegate)
        {
            actionBtnDelegates += actionBtnDelegate;
        }
        public void RemoveAction(ActionBtnDelegate actionBtnDelegate)
        {
            actionBtnDelegates -= actionBtnDelegate;
        }

        public void OnAction()
        {
            actionBtnDelegates?.Invoke();
        }
    }
    internal class Stamina
    {
        public bool UseStamina()
        {
            Console.WriteLine("스태미너를 사용합니다.");
            return true;
        }
    }
    internal class Item
    {
        public bool PickUp()
        {
            Console.WriteLine("아이템을 줍습니다.");
            return true;
        }
    }
    internal class Door
    {
        public bool Open()
        {
            Console.WriteLine("문을 엽니다.");
            return true;
        }
    }

    internal class Enemy
    {
        public bool StealthKill()
        {
            Console.WriteLine("암살을 합니다.");
            return true;
        }
    }
}
