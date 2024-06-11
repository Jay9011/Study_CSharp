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
}
