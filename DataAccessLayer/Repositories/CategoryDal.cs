using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class CategoryDal : ICategoryDal
    {
        Context context = new();
        public void Delete(Category category)
        {
            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public List<Category> GetList()
        {
            return context.Categories.ToList();
        }

        public void Insert(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
        }

        public void Update(Category category)
        {
            context.Categories.Update(category);
            context.SaveChanges();
        }
    }
}
