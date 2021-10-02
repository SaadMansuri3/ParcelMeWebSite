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

        public void Register(Customer cust)
        {
            if (cust != null)
            {
                db.Add(cust);
                Save();
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
