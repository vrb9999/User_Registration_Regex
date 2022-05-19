using Microsoft.VisualStudio.TestTools.UnitTesting;
using Email;
using System;
using System.Collections.Generic;
using System.Text;

namespace Email.Tests
{
    [TestClass()]
    public class ValidateTests
    {
        Validate validation = new Validate();
        [TestMethod]
        public void GivenEmail1_True()
        {
            string email = "abc@yahoo.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenEmail2_True()
        {
            string email = "abc-100@yahoo.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenEmail3_True()
        {
            string email = "abc.100@yahoo.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenEmail4_True()
        {
            string email = "abc111@abc.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenEmail5_True()
        {
            string email = "abc-100@abc.net";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenEmail6_True()
        {
            string email = "abc.100@abc.com.au";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenEmail7_True()
        {
            string email = "abc@1.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenEmail8_True()
        {
            string email = "abc@gmail.com.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenEmail9_True()
        {
            string email = "abc+100@gmail.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void GivenEmail1_False()
        {
            string email = "abc";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GivenEmail2_False()
        {
            string email = "abc@.com.my";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GivenEmail3_False()
        {
            string email = "abc123@gmail.a";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GivenEmail4_False()
        {
            string email = "abc123@.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GivenEmail5_False()
        {
            string email = "abc123@.com.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GivenEmail6_False()
        {
            string email = ".abc@abc.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GivenEmail7_False()
        {
            string email = "abc()*@gmail.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GivenEmail8_False()
        {
            string email = "abc@%*.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GivenEmail9_False()
        {
            string email = "abc..2002@gmail.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GivenEmail10_False()
        {
            string email = "abc.@gmail.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GivenEmail11_False()
        {
            string email = "abc@abc@gmail.com";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GivenEmail12_False()
        {
            string email = "abc@gmail.com.1a";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void GivenEmail13_False()
        {
            string email = "abc@gmail.com.aa.au";
            bool result = validation.ValidateEmail(email);
            Assert.AreEqual(false, result);
        }
    }
}