using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class Vacation
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public VacationType VacationType { get; set; }
        public DateTime StartOfVacation { get; set; }
        public DateTime EndOfVacation { get; set; }
        public string Comments { get; set; }
    }
}
