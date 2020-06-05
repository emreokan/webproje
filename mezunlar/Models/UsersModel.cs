using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mezunlar.Models
{
    public class UsersModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string UserLastName { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Adress { get; set; }
        public string Image { get; set; }
        public string Job { get; set; }
        public int JobstartYear { get; set; }
        public string Fakulte { get; set; }
        public string Bolum { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }
        public bool MezunOldumu { get; set; }
        public int MezunYıl { get; set; }
        public string Description { get; set; }
        public string Description50 { get; set; }
        public string JobStatu { get; set; }

    }
}