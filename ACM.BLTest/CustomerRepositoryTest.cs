using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "prottoy",
                EmailAddress = "pro@gmail.com",
                LastName = "roy"
            };
            //var a = new Customer(1);
            //{
            //    FirstName = "prottoy",
            //    LastName = "roy",
            //    EmailAddress = "pro@gmail.com"
            //};
            //a= expected;

            //act
            var actual = customerRepository.Retrieve(1);
            //expected = actual;

            //assert
           // Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.LastName, actual.LastName);




        }
        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "pro@gmail.com",
                FirstName = "prottoy",
                LastName = "roy",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "dhaka",
                        StreetLine2 = "mirpur",
                        City = "dhaka City",
                        State = "dhaka capital",
                        Country = "Bangladesh"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "dhaka2",
                        StreetLine2 = "mirpur2",
                        City = "dhaka City2",
                        State = "dhaka capital2",
                        Country = "Bangladesh2"
                    }
                }
            };
            var actual = customerRepository.Retrieve(1);
            //assert

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
           for(int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
            }


        }
    }
}
