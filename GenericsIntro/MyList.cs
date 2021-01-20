using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            //new'lendiği anda çalışan bu kod bloğu constructor'dır. ==> public MyList()
            items = new T[0];


        }
        public void Add(T item)
        {
            //geçici diziye referans değeri tutturulmalıdır.Yoksa dizi new'lendiği anda
            //dizi elemanları kaybolur.
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for(int i=0;i<tempArray.Length;i++)
            {
                items[i] = tempArray[i];
                
            }
            items[items.Length-1] = item;
            //Console.WriteLine(items.Length);
          
        }
        public int Length
        {
            get { return items.Length; }
        }
       
    }
}
