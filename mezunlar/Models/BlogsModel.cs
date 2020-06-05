using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mezunlar.Models
{
    public class BlogsModel
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Image { get; set; }
        public string Icerik { get; set; }
        public string Icerik50 { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public bool Onay { get; set; }
        public bool AnaSayfa { get; set; }
        public int CategoryId { get; set; }
        public int UsersId { get; set; }

    }
}