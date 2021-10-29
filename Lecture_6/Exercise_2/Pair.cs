namespace Exercise_2
{
    public class Pair<T1, T2>
    {
        public Pair(T1 t1, T2 t2)
        {
            value1 = t1;
            value2 = t2;
        }
        
        public T1 value1 { get; }
        public T2 value2 { get; }

        public Pair<T2,T1> Swap()
        {
            return new Pair<T2, T1>(value2, value1);
        }

        public Pair<T3, T2> setFst<T3>(T3 newValue)
        {
            return new Pair<T3, T2>(newValue, value2);
        }
        
        public Pair<T1, T3> setSnd<T3>(T3 newValue)
        {
            return new Pair<T1, T3>(value1, newValue);
        }
    }
}