using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly1
{
    public class ClassB
    {
        public void AccessFields()
        {
            ClassA a = new ClassA();
            a.PublicField = 1;          // 접근 가능
            // a.PrivateField = 2;      // 접근 불가능
            // a.ProtectedField = 3;    // 접근 불가능
            a.InternalField = 4;        // 접근 가능 (동일 어셈블리)
            a.ProtectedInternalField = 5; // 접근 가능 (동일 어셈블리)
            // a.PrivateProtectedField = 6; // 접근 불가능
        }
    }
}