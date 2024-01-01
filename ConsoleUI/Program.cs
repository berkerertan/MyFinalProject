﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{   //SOLID
    //Open Closed Principle
    private static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        foreach (var product in productManager.GetByUnitPrice(50,100))
        {
            Console.WriteLine(product.ProductName);

        }
        
    }
}