using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mezunlar.Models
{
    public class JobModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobName { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Description50 { get; set; }
        public string Image { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string YayınTarihi { get; set; }
        public string GecerlilikTarihi { get; set; }
        public string Tür { get; set; }
        public string Sender { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
    }
}