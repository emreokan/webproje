using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace mezunlar.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public string Description { get; set; }
        public ApplicationRole()
        {
                
        }
        public ApplicationRole(string rolename,string description)
        {
            this.Description = Description;
        }
    }
}