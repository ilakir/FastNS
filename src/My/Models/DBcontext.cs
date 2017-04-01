using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace My.Models
{
    public class DBcontext:IdentityDbContext<User>
    {
        
        //public DBcontext( <DBcontext> options) : base(options)
        //{
        //}
    }
}
