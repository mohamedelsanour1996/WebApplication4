﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId
        {
            get;
            set;
        }
       
        public string EmployeetName
        {
            get;
            set;
        }
        public double Salary
        {
            get;
            set;
        }
       
    }
}
