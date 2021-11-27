using Ecommerce.DataBase;
using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services
{
    public class ProductService
    {
        EcommerceContext db = new EcommerceContext();

        public void saveProduct(Product produt)
        {
            db.Products.Add(produt);
            db.SaveChanges();
        }

        public List<Product> getProduct()
        {
            return db.Products.ToList();
        }

        public Product getProduct(int Id)
        {
            return db.Products.Find(Id);
        }

        public void updateProduct(Product product)
        {
            db.Entry(product).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int Id)
        {
            var row = db.Products.Find(Id);
            db.Entry(row).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
