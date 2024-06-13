using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assembly1;

namespace Assembly2
{
    public class ClassC : ClassA
    {
        public void AccessFields()
        {
            PublicField = 1;          // 접근 가능
            // PrivateField = 2;      // 접근 불가능
            ProtectedField = 3;       // 접근 가능 (상속받은 클래스)
            // InternalField = 4;     // 접근 불가능 (다른 어셈블리)
            ProtectedInternalField = 5; // 접근 가능 (상속받은 클래스)
            // PrivateProtectedField = 6; // 접근 불가능 (다른 어셈블리)
        }
    }
}