﻿using System;
using System.Collections.Generic;
using System.Text;

namespace asclepio.infra.DecisionComponent.Models
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal AngleTilted { get; set; }
        public bool IsDizzy { get; set; }
        public string EmergencyContact { get; set; }
        public string DoctorName { get; set; }
    }
}