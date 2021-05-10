using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class SickLeave
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public SickLeaveType SickLeaveType { get; set; }
        public DateTime StartOfLeave { get; set; }
        public DateTime EndOfLeave { get; set; }
        public string Comments { get; set; }
    }
}
