using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class HealthCheckup
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public string Result { get; set; }
        public string Comments { get; set; }
        public  Employee Employee { get; set; }

    }
}
