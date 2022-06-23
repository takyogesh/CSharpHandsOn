using System;
using System.Collections.Generic;

namespace EmployeeOrganizationDFFirst.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeOrganizations = new HashSet<EmployeeOrganization>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<EmployeeOrganization> EmployeeOrganizations { get; set; }
    }
}
