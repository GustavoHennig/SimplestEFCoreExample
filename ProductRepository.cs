using Infra;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repositories
{
    public class ProductRepository 
    {

        private readonly MyDbContext dbContext;
        private readonly DbSet<Product> set;

        internal void Add(Product product)
        {
            this.set.Add(product);
        }

        public ProductRepository(MyDbContext dbContext)
        {
            this.dbContext = dbContext;
            this.set = dbContext.Products;
        }

        public Product Get(int id)
        {
            return this.set.FirstOrDefault(w => w.Id == id);
        }

        public IEnumerable<Product> ListByDescriptionContent(string description)
        {
            return this.set.Where(w => w.Description.Contains(description));
        }

        public void SaveChanges() {
            dbContext.SaveChanges();
        }
    }
}