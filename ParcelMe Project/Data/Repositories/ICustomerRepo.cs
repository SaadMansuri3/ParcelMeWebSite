using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface ICustomerRepo
    {
        IEnumerable<Customer> DisplayAll();
        void Register(Customer cust);
        void Save();
    }
}
