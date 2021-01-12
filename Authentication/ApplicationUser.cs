using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GrantManagementAuthentication.Authentication
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }


    }
}
