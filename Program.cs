// See https://aka.ms/new-console-template for more information
using Infra;
using Models;
using Repositories;

Console.WriteLine("Connecting to database...");

using(var dbContext = new MyDbContext())
{
    ProductRepository productRepository = new ProductRepository(dbContext);

    productRepository.Add(new Product { 
        Id = 1,
        Description = "My cool product",
        SalePrice = 9.9M,
        Status = Product.ProductStatus.Active
    });
    productRepository.SaveChanges();
    Product prod = productRepository.Get(1);

    Console.WriteLine(prod?.Description);
}