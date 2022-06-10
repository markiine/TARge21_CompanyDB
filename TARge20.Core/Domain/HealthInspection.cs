using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class HealthInspection
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime LastDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Note { get; set; }

        // FK
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
