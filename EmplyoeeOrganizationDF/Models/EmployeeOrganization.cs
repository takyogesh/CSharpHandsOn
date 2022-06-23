using System;
using System.Collections.Generic;

namespace EmployeeOrganizationDFFirst.Models
{
    public partial class EmployeeOrganization
    {
        public int Id { get; set; }
        public string OrganizationName { get; set; } = null!;
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
    }
}
