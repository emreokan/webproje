using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mezunlar.entity
{
    public class MainPage
    {
        public int Id { get; set; }
        public IEnumerable<Job> Jobs { get; set; }
        public IEnumerable<Etkinlikler> Etkinliklers { get; set; }
    }
}