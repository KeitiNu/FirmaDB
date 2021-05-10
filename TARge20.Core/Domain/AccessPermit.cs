using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class AccessPermit
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public AccessPermitType AccessPermitType { get; set; }
        public DateTime StartOfAccess { get; set; }
        public DateTime EndOfAccess { get; set; }

    }
}
