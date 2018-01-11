﻿using BlastAsia.DigiBook.Domain.Models.Appointments;
using System;
using System.Collections.Generic;
using System.IO;

namespace BlastAsia.DigiBook.Domain.Models.Employees
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAddress { get; set; }
        public Stream Photo { get; set; } 
        public string Extension { get; set; }
        public string OfficePhone { get; set; }
        public Guid EmployeeId { get; set; } //CANNOT BE SET
        public List<Appointment> Appointments { get; set; }
    }
}