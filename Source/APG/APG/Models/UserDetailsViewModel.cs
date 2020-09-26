using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APG.Models
{
    public class UserDetailsViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string HaveAlliance { get; set; }
        public string HavePrescriptions { get; set; }
        public string TakingMedications { get; set; }
    }
}