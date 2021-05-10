using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARge20.Core.Domain
{
    public class WorkRelationship
    {
        [Key]
        public Guid Id { get; set; }
        public Employee Employee { get; set; }
        public JobTitle JobTitle { get; set; }
        public BranchHouse BranchHouse { get; set; }
        public DateTime EmplyeedFrom { get; set; }
        public DateTime EmplyeedUntil { get; set; }
        public float Workload { get; set; }
    }
}
