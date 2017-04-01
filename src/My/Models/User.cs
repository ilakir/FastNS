using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace My.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; } 
        public string Sity { get; set; }
        public string EmailIndex { get; set; }
    }
}
