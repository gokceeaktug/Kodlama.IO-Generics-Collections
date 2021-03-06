﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.tip class oluşturma
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //2.tip class oluşturma
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitInStock = 5, ProductName = "Kalem", UnitPrice = 35 };
            
            
            //instance
            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
            productManager.Update(product1);
            

            //productManager.Topla2(3,6);
            //int toplamaSonucu = productManager.Topla1(3, 6);
            //Console.WriteLine(toplamaSonucu*2);


        }
    }
}
