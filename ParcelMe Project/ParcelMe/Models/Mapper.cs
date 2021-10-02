using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcelMe.Models
{
    public class Mapper
    {
        public static Data.Customer Map(Models.CustomerModel cust)
        {
            return new Data.Customer()
            {
                Id = cust.Id,
                Name = cust.Name,
                Username = cust.Username,
                Password = cust.Password,
                Address = cust.Address,
                Zipcode = cust.Zipcode,
                City = cust.Zipcode,
                Mobile = cust.Mobile,
                Email = cust.Email,
                State = cust.State
            };
        }
        public static Models.CustomerModel Map(Data.Customer cust)
        {
            return new Models.CustomerModel()
            {
                Id = cust.Id,
                Name = cust.Name,
                Username = cust.Username,
                Password = cust.Password,
                Address = cust.Address,
                Zipcode = cust.Zipcode,
                City = cust.Zipcode,
                Mobile = cust.Mobile,
                Email = cust.Email,
                State = cust.State
            };
        }

        public static IEnumerable<Models.CustomerModel> Map(IEnumerable<Data.Customer> cust)
        {
            return cust.Select(Map);
        }
    }
}
