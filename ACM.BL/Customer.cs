using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        public Customer():this(0)
        {

        }
        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public static int InstanceCount { get; set; }
        private string _lastName;
        public List<Address> AddressList { get; set; }
        public string LastName
        {
            get
            {
                //any code here
                return _lastName;
            }
            set
            {
                //any code here
                _lastName = value;
            }
        }
            public string FirstName { get; set; }
            public string EmailAddress { get; set; }
            public int CustomerId { get; private set; }
            public string FullName
            {
                get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    //if there is first name
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        //if there is full name or last name is equvalant to full name
                        fullName += ", ";
                    }
                    fullName += FirstName;
            

                }
                return fullName;
                //return FirstName + " " + LastName;
            }
            }
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;

        }
        public bool Save()
        {
            return true;
        }
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }
        public List<Customer> Retrieve()
        {
            
            return new List<Customer>();
        }


    }
    }

