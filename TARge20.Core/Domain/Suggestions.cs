using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Suggestions
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Recipient { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        
    }
}
