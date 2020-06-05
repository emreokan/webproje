using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mezunlar.Models
{
    public class RegisterUserModel
    {
        public IEnumerable<UsersModel> UsersModels { get; set; }
        public IEnumerable<Register> Registers { get; set; }
    }
}