using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamplate.DAL.Extend
{
    public class AppUsers: IdentityUser
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        //[Required]
        //public override string Email { get; set; }
        public int UsernameChangeLimit { get; set; } = 10;
        public byte[] ProfilePicture { get; set; }

        public bool IsAgree { get; set; }

    }
}
