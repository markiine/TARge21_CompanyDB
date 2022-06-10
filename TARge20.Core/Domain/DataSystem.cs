using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class DataSystem
    {
        [Key]
        public Guid Id { get; set; }
        public string SystemName { get; set; }

        // FK        
        public Guid AccessPermissionId { get; set; }
        public AccessPermission AccessPermission { get; set; }
    }
}
