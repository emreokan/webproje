using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace mezunlar.entity
{
    public class Album
    {
        public int Id { get; set; }
        [DisplayName("İsim")]
        public string Name { get; set; }
        [DisplayName("Resim")]
        public string Image { get; set; }


    }
}