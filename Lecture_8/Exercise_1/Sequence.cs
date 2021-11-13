using System.Collections;
using System.Collections.Generic;

namespace Exercise_1
{
    public class Sequence : IEnumerable<int>
    {
        private MyEnumerator _enumerator;
        public Sequence(int start, int count, int skip)
        {
            _enumerator = new MyEnumerator(start, count, skip);
        }
        
        public IEnumerator<int> GetEnumerator()
        {
            return _enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}