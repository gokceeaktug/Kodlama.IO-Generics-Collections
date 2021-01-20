using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            //MyList<int> isimler = new MyList<int>();
            //MyList<Product> isimler = new MyList<Product>();
            isimler.Add("Gökçe Aktuğ");
            Console.WriteLine(isimler.Length);
            isimler.Add("Büşra Özen");
            Console.WriteLine(isimler.Length);
            isimler.Add("Ezgi Aslan");
            Console.WriteLine(isimler.Length);
            isimler.Add("Büşra Ayverdi");
            Console.WriteLine(isimler.Length);



            
        }
    }
}
