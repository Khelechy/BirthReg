﻿using birthreg.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace birthreg.ViewModels
{
    public class AddChildViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string State { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public double Weigth { get; set; }
        public double Length { get; set; }
        public string MidWife { get; set; }
        public string ContactNumber { get; set; }
        public string ContactEmail { get; set; }
        public GenderEnum Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ParentId { get; set; }
    }
}
