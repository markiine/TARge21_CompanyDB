using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class ItemsToRent
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string ItemName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Note { get; set; }
        //FK EmployeeId
        public Guid? EmployeeId { get; set; }
        public Employee Employee { get; set; }

        //FK BranchOffice
        public Guid BranchOfficeId { get; set; }
        public BranchOffice BranchOffice { get; set; }
    }
}
