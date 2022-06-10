using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class BranchOffice
    {
        [Key]
        public Guid Id { get; set; }
        public string RegistryNr { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Note { get; set; }

        //FK - Company
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }

        public List<Employee> Employees { get; set; }
        public List<ItemsToRent> ItemsToRent { get; set; }

    }
}
