﻿namespace EmployeeAdminPortal.Model
{
    public class UpdateEmployeeDto
    {
        public required string Name { get; set; }

        public required string Email { get; set; }

        public string? Phone { get; set; }

        public decimal salary { get; set; }
    }
}
