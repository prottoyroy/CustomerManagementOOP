using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameValid()
        {
            //arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            string expected = "Baggins" ;
            //act
            string actual = customer.FullName;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ValidateaValid()
        {
            //arrange
            Customer customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "pro@gmail.com";

            var expected = true;
            //act
            var actual = customer.Validate();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ObjectTypeTest()
        {
            //arrange
            Customer customer1 = new Customer();
            customer1.FirstName = "pro";
            var customer2 = customer1;
            customer2.FirstName = "pro";
            string expected = "pro";


            //act
            var actual = "pro";
            
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IntergerTypeTest()
        {
            //arrange
            int i1;
            i1 = 40;
            //act
            int i2 = i1;
            i2 = 2;

            //assert
           // Assert.AreEqual(2, i2);

            Assert.AreEqual(40, i1);
        }
        [TestMethod]
        public void StaticTest()
        {
            //arrange
            var customer = new Customer();
            Customer.InstanceCount += 1;
            
            Customer.InstanceCount += 1;
            
            Customer.InstanceCount += 1;
            //act


            //assert
            Assert.AreEqual(3, Customer.InstanceCount);

            
        }
    }
}
