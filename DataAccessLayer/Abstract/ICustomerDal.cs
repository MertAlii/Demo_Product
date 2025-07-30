using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal
    {
        void Insert(Customer customer);
        void Delete(Customer customer);
        void Update(Customer customer);
        List<Customer> GetList();

    }
}
