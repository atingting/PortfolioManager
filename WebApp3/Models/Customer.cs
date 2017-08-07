using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp3.Models
{
    public class Customer
    {
        public Customer() { }

        public Customer(int id, string firstname, string lastname, int amout, string data)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            AmountOwed = amout;
            DateOfBirth = data;
        }
        public int Id
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public int AmountOwed
        {
            get;
            set;
        }

        public string DateOfBirth
        {
            get;
            set;
        }
    
}
}