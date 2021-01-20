using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //5 elemanlı bir boş dizi oluşturma işlemi yapıldı. Bellekte yeni bir dizi oluşturuldu.
            //Önceki değerler kaybedilir.Veriler çekilemez.
            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //dizi 4 elemanlı olduğunda 5 .eleman ekleyerek konsole yazılamamz.
            //isimler[4]= "İlker";
            //Console.WriteLine(isimler[4]);
            List<string> isimler2 = new List<string> { "Engin", "Murat", "Kerem", "Halil" };
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);

            
        }
    }
}
