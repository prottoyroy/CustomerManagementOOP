using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository;

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            if (customerId == 1)
            {
               
                customer.EmailAddress = "pro@gmail.com";
                customer.FirstName = "prottoy";
                customer.LastName = "roy";
            }
            return customer;
        }
        public List<Customer> Retrieve()
        {

            return new List<Customer>();
        }

    }
}
