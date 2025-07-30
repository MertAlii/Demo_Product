using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal
    {
        void Insert(Product product);
        void Delete(Product product);
        void Update(Product product);
        List<Product> GetList();
    }
}
