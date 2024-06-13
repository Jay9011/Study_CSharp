using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly1
{
    public class ClassA
    {
        public int PublicField;         // 모든 곳에서 접근 가능
        private int PrivateField;       // ClassA 내에서만 접근 가능
        protected int ProtectedField;   // ClassA 및 상속받은 클래스에서만 접근 가능
        internal int InternalField;     // Assembly1.dll 내에서 접근 가능
        protected internal int ProtectedInternalField; // Assembly1.dll 내에서 또는 상속받은 클래스에서 접근 가능
        private protected int PrivateProtectedField; // Assembly1.dll 내에서 상속받은 클래스에서 접근 가능

        public void AccessFields()
        {
            // ClassA 내에서는 모든 필드에 접근 가능
            PublicField = 1;
            PrivateField = 2;
            ProtectedField = 3;
            InternalField = 4;
            ProtectedInternalField = 5;
            PrivateProtectedField = 6;
        }
    }
}
