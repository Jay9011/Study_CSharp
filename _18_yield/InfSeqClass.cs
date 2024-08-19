using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_yield
{
    internal class InfSeqClass
    {
        public static IEnumerable<int> InfiniteSequence()
        {
            int i = 0;
            while (true)
            {
                yield return i++;
            }
        }
        public static void Exmaple()
        {
            var iterator = InfiniteSequence().GetEnumerator();

            Console.WriteLine(iterator.Current); // 아직 시작 전이라 초기 상태
            iterator.MoveNext();
            Console.WriteLine(iterator.Current); // 0
            iterator.MoveNext();
            Console.WriteLine(iterator.Current); // 1
            iterator.MoveNext();
            Console.WriteLine(iterator.Current); // 2

            // 두 번째 반복자 생성
            var newIterator = InfiniteSequence().GetEnumerator();
            newIterator.MoveNext();
            Console.WriteLine(newIterator.Current); // 0, 새로운 반복자이므로 처음부터 시작
            newIterator.MoveNext();
            Console.WriteLine(newIterator.Current); // 1
        }
    }
}
