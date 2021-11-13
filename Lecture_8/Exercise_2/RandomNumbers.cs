using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise_2
{
    public class RandomNumbers : IEnumerable<int>
    {
        private MyEnumerator _enumerator;
        
        public RandomNumbers(int seed, int max_value, int min_value)
        {
            _enumerator = new MyEnumerator(seed, min_value, max_value);
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