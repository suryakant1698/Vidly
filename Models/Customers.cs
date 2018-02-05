using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebApplication2.ViewModels;

namespace WebApplication2.Models
{
    public class Customers
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name{ get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType membershiptype { get; set; }
        public byte MembershipTypeID { get; set; }
        
        public DateTime BirthDate { get; set; }

    }
}