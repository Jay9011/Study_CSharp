using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_OOP
{
    class MyClass
    {
        public int Value;
        public string Name;

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return this.Value == ((MyClass)obj).Value;
        }
    }

    public class BaseClass
    {
        public string Name;
        protected int MyProperty;

        public BaseClass()
        {
            Name = "BaseClass";
            MyProperty = 0;
        }
        public BaseClass(string name, int myProperty)
        {
            Name = name;
            MyProperty = myProperty;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Class Name: {Name}");
            Console.WriteLine($"MyProperty: {MyProperty}");
        }
    }
    public class DerivedClass : BaseClass
    {
        private string description;

        public DerivedClass()
        {
            Name = "DerivedClass";
            MyProperty = 1;
            description = "파생 클래스만의 멤버";
        }
        public DerivedClass(string description) : base("DerivedClass", 1)   // 부모 클래스의 생성자 호출
        {
            this.description = description;
        }

        public override void PrintInfo()
        {
            base.MyProperty = 2;    // 부모 클래스의 protected 멤버에 접근 가능
            base.PrintInfo();       // 부모 클래스의 메서드 호출

            Console.WriteLine($"Description: {description}");
        }
    }
}
