using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Harry";
            customer.LastName = "Potter";

            string expected = "Potter, Harry";

            //-- Act
            string actual = customer.FullName;

            //-- Assert - verifies that the expected value matches the actual value
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.LastName = "Potter";
            string expected = "Potter";

            //-- Act
            string actual = customer.FullName;

            //-- Assert - verifies that the expected value matches the actual value
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange - sets ups the tests 
            Customer customer = new Customer();
            customer.FirstName = "Harry";
            string expected = "Harry";

            //-- Act - contains the code we are testing
            string actual = customer.FullName;

            //-- Assert - verifies that the expected value matches the actual value
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Rosise";
            Customer.InstanceCount += 1;

            //-- Act

            //-- Assert - verifies that the expected value matches the actual value
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer();
            customer.LastName = "Baggins";
            customer.EmailAddress = "fbaggins@me.net";


            var expected = true;
            //-- Act - call validate method
            var actual = customer.Validate();

            //-- Assert - verifies that the expected value matches the actual value
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var customer = new Customer();
            customer.EmailAddress = "fbaggins@me.net";


            var expected = false;

            //-- Act - call validate method
            var actual = customer.Validate();

            //-- Assert - verifies that the expected value matches the actual value
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingEmailAddress()
        {
            //-- Arrange
            var customer = new Customer();
            customer.LastName = "Baggins";
            

            var expected = false;
            //-- Act - call validate method
            var actual = customer.Validate();

            //-- Assert - verifies that the expected value matches the actual value
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingEmailAndEmailAddress()
        {
            //-- Arrange
            var customer = new Customer();

            var expected = false;
            //-- Act - call validate method
            var actual = customer.Validate();

            //-- Assert - verifies that the expected value matches the actual value
            Assert.AreEqual(expected, actual);
        }




    }
}

