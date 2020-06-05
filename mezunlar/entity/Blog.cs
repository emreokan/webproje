using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using mezunlar.Models;

namespace mezunlar.entity
{
    public class Blog
    {
        public int Id { get; set; }
        [DisplayName("Başlık")]
        public string Baslik { get; set; }
        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }
        [DisplayName("Resim")]
        public string Image { get; set; }
        [DisplayName("İçerik")]
        public string Icerik { get; set; }
        [DisplayName("Eklenme Tarihi")]
        public DateTime EklenmeTarihi { get; set; }
        [DisplayName("Onay")]
        public bool Onay { get; set; }
        [DisplayName("Ana Sayfa")]
        public bool AnaSayfa { get; set; }
        [DisplayName("Kategori Id")]
        public int CategoryId { get; set; }
        [DisplayName("Kategori")]
        public Category Category { get; set; }
        [DisplayName("Kullanıcı ID")]
        public int UsersId { get; set; }
        [DisplayName("Kullanıcı")]
        public Users Users { get; set; }
       
    }
}