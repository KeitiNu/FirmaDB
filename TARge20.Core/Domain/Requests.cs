using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Requests
    {
        [Key]
        public Guid Id { get; set; }
        [InverseProperty("Sender")]
        public Employee Sender { get; set; }
        [InverseProperty("Recipient")]
        public Employee Recipient { get; set; }
        public DateTime Date { get; set; }
        public String Content { get; set; }
    }
}
