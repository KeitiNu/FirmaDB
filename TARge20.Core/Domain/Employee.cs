using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TARge20.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [StringLength(11), Required]
        public string SocialSecurityNumber { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(25)]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        public string Comments { get; set; }


        public ICollection<Children> Childrens { get; set; }
        public ICollection<HealthCheckup> HealthCheckup { get; set; }
        public ICollection<Vacation> Vacation { get; set; }
        public ICollection<SickLeave> SickLeave { get; set; }
        public ICollection<AccessPermit> AccessPermit { get; set; }
        public ICollection<Loaning> Loaning { get; set; }
        public ICollection<WorkRelationship> WorkRelationship { get; set; }
        public ICollection<Suggestions> Suggestions { get; set; } 
        public ICollection<Requests> Sender { get; set; } 
        public ICollection<Requests> Recipient { get; set; } 


    } 
}


