using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDal : IGenericDal<Customer>
    {
        List<Customer> GetCustomerListWithJob();
    }
}
