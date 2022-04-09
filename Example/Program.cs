using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictioanry<string> Cities = new MyDictioanry<string>();
            Cities.Add("Çanakkale");
            Cities.Add("İstanbul");
            Cities.Add("Ankara");
            Cities.Add("Bursa");
            Console.WriteLine(Cities.Count);
        }
    }
    class MyDictioanry<T>
    {
        private T[] _array;
        private T[] _tempArray;
        public MyDictioanry()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }

    }
}
