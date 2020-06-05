using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace mezunlar.entity
{
    public class Users
    {
        public int Id { get; set; }
        [DisplayName("İsim")]
        public string Username { get; set; }
        [DisplayName("Soyisim")]
        public string UserLastName { get; set; }
        [DisplayName("Mail")]
        public string Mail { get; set; }
        [DisplayName("Telefon")]
        public string Tel { get; set; }
        [DisplayName("Adress Bilgisi")]
        public string Adress { get; set; }
        [DisplayName("Resim")]
        public string Image { get; set; }
        [DisplayName("İş Tanımı")]
        public string Job { get; set; }
        [DisplayName("İş Başlangıç Tarihi")]
        public int JobstartYear { get; set; }
        [DisplayName("Fakültesi")]
        public string Fakulte { get; set; }
        [DisplayName("Bölümü")]
        public string Bolum { get; set; }
        [DisplayName("Ana Sayfa")]
        public bool IsHome { get; set; }
        [DisplayName("Onay")]
        public bool IsApproved { get; set; }
        [DisplayName("Mezun Oldumu")]
        public bool MezunOldumu { get; set; }
        [DisplayName("Mezuniyet Yılı")]
        public int MezunYıl { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("iş Durumu")]
        public string JobStatu { get; set; }

    }
}