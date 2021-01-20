using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");

        }
        public int Topla1(int sayi1,int sayi2)
        {
            //integer topla class'ının içine değişken girilmelidir.
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2)
        {
            //void topla class'ının içi return dönülmez.
            
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
