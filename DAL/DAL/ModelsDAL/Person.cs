﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL.ModelsDAL
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; } 
        [Required]
        public string LastName { get; set; }
        public string Position { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public Organization Organization { get; set; }
    }
}
