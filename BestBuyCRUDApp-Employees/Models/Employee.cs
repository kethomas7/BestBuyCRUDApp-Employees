﻿namespace BestBuyCRUDApp_Employees.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }

        public char ? MiddleInitial { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public string Title { get; set; }

        public DateTime DateofBirth { get; set; }


    }
}
