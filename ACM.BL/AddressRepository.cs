using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);
            if (addressId == 1)
            {
                address.StreetLine1 = "dhaka";
                address.StreetLine2 = "Mirpur";
                address.City = "Dhaka City";
                address.State = "Dhaka Capital";
                address.Country = "Bangladesh";
                address.PostalCode = "1204";

            }
            return address;
        }

        public IEnumerable<Address>RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "dhaka",
                StreetLine2 = "mirpur",
                City = "dhaka City",
                State = "dhaka capital",
                Country = "Bangladesh"


            };
            addressList.Add(address);
             address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "dhaka2",
                StreetLine2 = "mirpur2",
                City = "dhaka City2",
                State = "dhaka capital2",
                Country = "Bangladesh2"


            };
            addressList.Add(address);
            return addressList;
        }
        public bool Save()
        {
            return true;
        }
    }
}
