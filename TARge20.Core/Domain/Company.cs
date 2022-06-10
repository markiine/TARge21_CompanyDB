using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }
        public string RegistryNr { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNameShort { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }
        public List<BranchOffice> BranchOffices { get; set; }
    }
}
