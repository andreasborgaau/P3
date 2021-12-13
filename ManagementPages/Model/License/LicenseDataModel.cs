﻿using System;

namespace ManagementPages.Model.License
{
    public class LicenseDataModel
    {
        public int LicenseId { get; set; } //generated by database

        public string CustomerName { get; set; }

        public DateTime RegistrationDate { get; set; }
    }
}