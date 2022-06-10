using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class AccessPermission
    {
        [Key]
        public Guid Id { get; set; }
        public string PermissionName { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public string Note { get; set; }

        // FK
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public List<DataSystem> DataSystems { get; set; }
    }
}
