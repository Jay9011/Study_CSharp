using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace _15_ReflectionAndAttribute
{
    public class CustomAttribute : System.Attribute
    {
        public string Description { get; set; }
        public CustomAttribute(string description)
        {
            Description = description;
        }
    }
    [Custom("Reflection 어셈블리 파일의 TestClass")]
    internal class Program_TestClass
    {
        private int PrivateInt;
        protected double ProtectedDouble;
        public string PublicString;
        private void PrivateMethod()
        {
            Console.WriteLine("Program Private Method 호출");
        }
    }

    internal class Program
    {
        static string GetAccessName(FieldInfo field)
        {
            if (field.IsPublic)
            {
                return "Public";
            }
            else if (field.IsPrivate)
            {
                return "Private";
            }
            else if (field.IsFamily)
            {
                return "Protected";
            }
            else
            {
                return "Internal";
            }
        }
        static void TypeCheck(Type type)
        {
            // 해당 타입의 모든 필드 정보를 얻어온다.
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance);
            foreach (FieldInfo field in fields)
            {
                Console.WriteLine($"{GetAccessName(field)} {field.FieldType.Name} {field.Name}");
            }
        }

        static void Main(string[] args)
        {
            ReflectionClass.Run();
            /* -- 실행 결과 --
             * EmbeddedAttribute        ──┐
             * NullableAttribute          │
             * NullableContextAttribute   │  Reflection 어셈블리 파일
             * Program_TestClass          │
             * Program                    │
             * ReflectionClass          ──┘
             */

            /*
             * EmbeddedAttribute        ──┐
             * NullableAttribute          │
             * NullableContextAttribute   │  Predicate 어셈블리 파일
             * Utilities                  │
             * Program                    │
             * <>c                      ──┘
             */

            // Program_TestClass test = new Program_TestClass();
            // TypeCheck(test.GetType());
            /*
             * Private Int32 PrivateInt
             * Protected Double ProtectedDouble
             * Public String PublicString
             */

            // object? DynamicInstance = Activator.CreateInstance(typeof(Program_TestClass));
            // Console.WriteLine($"{DynamicInstance.GetType().Name}");
            /* -- 실행 결과 --
             * Program_TestClass
             */

            // MethodInfo? method = DynamicInstance.GetType().GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
            // method?.Invoke(DynamicInstance, null);
            /* -- 실행 결과 --
             * Program Private Method 호출
             */

            Type type = typeof(Program_TestClass);
            object[] attributes = type.GetCustomAttributes(typeof(CustomAttribute), true);
            foreach (CustomAttribute attribute in attributes)
            {
                Console.WriteLine(attribute.Description);
            }
            /* -- 실행 결과 --
             * Reflection 어셈블리 파일의 TestClass
             */
        }
    }
}
