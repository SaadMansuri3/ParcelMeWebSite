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
        Customer GetCustomerById(int id);
        Customer Edit(int id);
        Customer Login(string Username, string Password);
        Customer Profile(string uname);
        void Save();
    }
}
