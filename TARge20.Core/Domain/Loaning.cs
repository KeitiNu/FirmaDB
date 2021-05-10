using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Loaning
    {
        [Key]
        public Guid Id { get; set; }
        public Inventory Inventory { get; set; }
        public Employee Employee { get; set; }
        public DateTime StartOfLoan { get; set; }
        public DateTime EndOfLoan { get; set; }
    }
}
