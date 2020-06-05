using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mezunlar.entity
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Kategori Adı")]
        [StringLength(maximumLength:100,ErrorMessage = "En fazla 100 karakter girilebilir.")]
        public string KategoriAdi { get; set; }
        [DisplayName("Resim")]
        public string Image { get; set; }
        public List<Blog> Bloglar { get; set; }
    }
}