using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mezunlar.Models
{
    public class BlogModelCotegoryModel
    {
        public IEnumerable<UsersModel> UsersModels { get; set; }
        public IEnumerable<BlogsModel> Blogs { get; set; }
        public IEnumerable<CategoryModel> Category { get; set; }
        public IEnumerable<Register> Registers { get; set; }
    }
}