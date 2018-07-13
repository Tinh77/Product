using System;

namespace Products
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Product[] products = new Product[5];
            
            var productname0 = "Quyen";
            products[0] =  new Phone();
            products[0]._productName = productname0;
            products[0]._productId = 0;
            products[0]._productPrice = 2500;
            Console.WriteLine("Product {0} -Book: id={1},name={2},price={3} - computeTax = {4}", 0, products[0]._productId,
                products[0]._productName, products[0]._productPrice, products[0].ComputeTax());
            
            var productname = "Quyen1";
            products[1] = new Book();
            products[1]._productName = productname;
            products[1]._productId = 1;
            products[1]._productPrice = 2500;
            Console.WriteLine("Product {0} -Book: id={1},name={2},price={3} - computeTax = {4}", 1, products[1]._productId,
                products[1]._productName, products[1]._productPrice, products[1].ComputeTax());
            
            var productname1 = "Quyen2";
            products[2] = new Book();
            products[2]._productName = productname1;
            products[2]._productId = 2;
            products[2]._productPrice = 2500;
            Console.WriteLine("Product {0} -Book: id={1},name={2},price={3} - computeTax = {4}", 2, products[2]._productId,
                products[2]._productName, products[2]._productPrice, products[2].ComputeTax());
            
            var productname2 = "Quyen3";
            products[3] = new Phone();
            products[3]._productName = productname2;
            products[3]._productId = 3;
            products[3]._productPrice = 2500;
            Console.WriteLine("Product {0} -Book: id={1},name={2},price={3} - computeTax = {4}", 3, products[3]._productId,
                products[3]._productName, products[3]._productPrice, products[3].ComputeTax());
            
            var productname3 = "Quyen3";
            products[4] = new Phone();
            products[4]._productName = productname3;
            products[4]._productId = 4;
            products[4]._productPrice = 2500;
            Console.WriteLine("Product {0} -Book: id={1},name={2},price={3} - computeTax = {4}", 4, products[4]._productId,
                products[4]._productName, products[4]._productPrice, products[4].ComputeTax());
            
            
        }
    }
}