using System.Collections;

namespace _10_Generic
{
    public class BaseClass
    {}
    public class DerivedClass : BaseClass
    {}

    public static class Utilities
    {
        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) >= 0 ? a : b;
        }
        public static B Allocate<B, D>() where D : B, new()
        {
            return new D();
        }
    }
    public class Dict<K, V> where K : ICollection
                            where V : IComparable
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass myClass = Utilities.Allocate<BaseClass, DerivedClass>();
        }
    }
}
