using Ecommerce.DataBase;
using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ecommerce.Services
{
    public class CategoriesServices
    {
        EcommerceContext db = new EcommerceContext();
        public void saveCategory(Category category)
        {
            

            //db.Categories.Add(category);

            // or we can perform this action by following code also.
            using (var context = new EcommerceContext())
            {
                context.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public List<Category> getCategories()
        {
            return db.Categories.ToList();
            
        }

        public Category getCatagory(int Id)
        {
            return db.Categories.Find(Id);
        }

        public void updateCategory(Category category)
        {
            db.Entry(category).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public void deleteCategory(int Id)
        {
            var row = db.Categories.Find(Id);
            db.Entry(row).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
