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

        public int value
        {
            get { return value; }
            protected set { this.value = value; }
        }

        public BaseClass()
        {
            Name = "BaseClass";
            value = 0;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Value: {value}");
        }
    }

    public class DerivedClass : BaseClass
    {
        private string description;

        public DerivedClass()
        {
            Name = "DerivedClass";
            value = 1;
            description = "파생 클래스만의 멤버";
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}, Value: {value}, Description: {description}");
        }
    }
}
