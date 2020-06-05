using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace mezunlar.entity
{
    public class Job
    {
        public int Id { get; set; }
        [DisplayName("İsim")]
        public string Name { get; set; }
        [DisplayName("iş Tanımı ")]
        public string JobName { get; set; }
        [DisplayName("Konum")]
        public string Location { get; set; }
        [DisplayName("Açıklama")]
        public string Description { get; set; }
        [DisplayName("Resim")]
        public string Image { get; set; }
        [DisplayName("Mail")]
        public string Mail { get; set; }
        [DisplayName("Telefon")]
        public string Tel { get; set; }
        [DisplayName("Yayın Tarihi")]
        public string YayınTarihi { get; set; }
        [DisplayName("Geçerlilik Tarihi")]
        public string GecerlilikTarihi { get; set; }
        [DisplayName("Tür")]
        public string Tür { get; set; }
        [DisplayName("Gönderici")]
        public string Sender { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; }


    }
}