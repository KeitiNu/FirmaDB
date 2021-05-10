using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Children
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)] 
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }      
        public string Comments { get; set; }
        [Required]
        public Employee Employee { get; set; }

    }
}
