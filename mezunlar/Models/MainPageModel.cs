using mezunlar.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mezunlar.Models
{
    public class MainPageModel
    {
        public int Id { get; set; }
        public IEnumerable<JobModel> Jobs { get; set; }
        public IEnumerable<EtkinliklerModel> Etkinliklers { get; set; }
        public IEnumerable<UsersModel> UsersModels { get; set; }
        public IEnumerable<BlogsModel> Blogs { get; set; }
    }
}