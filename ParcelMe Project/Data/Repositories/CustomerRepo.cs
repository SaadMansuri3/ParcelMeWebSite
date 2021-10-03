using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class CustomerRepo : ICustomerRepo
    {
        ParcelMeContext db =new ParcelMeContext();

        public IEnumerable<Customer> DisplayAll()
        {
            var data = db.Customers.ToList();
            return data;
        }

        public Customer Edit(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int id)
        {
            if (id != 0)
            {
                var data = db.Customers.Where(x => x.Id == id).FirstOrDefault();
                return data;
            }
            return null;
        }

        public Customer GetCustomerByUsername(string uname)
        {
            if (uname != null)
            {
                var data = db.Customers.Where(x => x.Username == uname).FirstOrDefault();
                return data;
            }
            return null;
        }

        public Customer Login(string uname, string pass)
        {
            var data = db.Customers.Where(x => x.Username == uname && x.Password == pass).FirstOrDefault();
            if (data != null)
                return data;
            else
                return null;
        }

        public void Register(Customer cust)
        {
            if (cust != null)
            {
                db.Add(cust);
                Save();
            }
        }

        public Customer Profile(string uname)
        {
            var cust = GetCustomerByUsername(uname);
            return cust;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
