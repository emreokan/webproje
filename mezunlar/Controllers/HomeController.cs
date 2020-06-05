using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mezunlar.entity;
using mezunlar.Models;

namespace mezunlar.Controllers
{
 
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            MainPageModel Main = new MainPageModel();

            Main.Etkinliklers = _context.Etkinliklers.Where(i => i.IsApproved && i.IsHome).Select(i => new EtkinliklerModel()
            {
                Id = i.Id,
                Name = i.Name,
                Image = i.Image ?? "JobPhoto.png",
                IsHome = i.IsHome,
                IsApproved = i.IsApproved,
                Description = i.Description,
                Location = i.Location,
                Description50 = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                YayınTarihi = i.YayınTarihi,
                GecerlilikTarihi = i.GecerlilikTarihi,


            }).ToList();
            Main.UsersModels = _context.Users.Where(i => i.IsApproved && i.IsHome).Select(i => new UsersModel()
            {

                Id = i.Id,
                Username = i.Username,
                UserLastName = i.UserLastName,
                Image = i.Image ?? "JobPhoto.png",
                Bolum = i.Bolum,
                Job = i.Job,
                JobStatu = i.JobStatu,
                Description = i.Description,
                Description50 = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description

            }).ToList();


            Main.Jobs = _context.Jobs.Where(i => i.IsApproved && i.IsHome).Select(i => new JobModel()
            {
                Id = i.Id,
                Name = i.Name,
                JobName = i.JobName,
                Image = i.Image ?? "JobPhoto.png",
                Location = i.Location,
                Description = i.Description,
                Mail = i.Mail,
                Tel = i.Tel,
                YayınTarihi = i.YayınTarihi,
                GecerlilikTarihi = i.GecerlilikTarihi,
                Tür = i.Tür,
                Sender = i.Sender,
                IsApproved = i.IsApproved,
                IsHome = i.IsHome,
                Description50 = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description

            }).ToList();
           
            Main.Blogs = _context.Bloglar.Where(i => i.Onay && i.AnaSayfa && i.Id<3).Select(i => new BlogsModel()
            {
                Id = i.Id,
                Image = i.Image ?? "JobPhoto.png",
                Baslik = i.Baslik.Length>100?i.Baslik.Substring(0,100)+"...":i.Baslik,
                Aciklama = i.Aciklama.Length > 100 ? i.Aciklama.Substring(0, 100) + "..." : i.Aciklama,
                EklenmeTarihi = i.EklenmeTarihi,
                Icerik = i.Icerik,
                Icerik50 = i.Icerik.Length > 50 ? i.Icerik.Substring(0, 50) + "..." : i.Icerik,
                UsersId = i.UsersId,
                CategoryId = i.CategoryId

            }).ToList();
     
            return View(Main);
        }
        [Authorize(Roles = "user")]
        public ActionResult Etkinlikler()
        {
            var Etkinlik = _context.Etkinliklers
                .Where(i => i.IsApproved)
                .Select(i => new EtkinliklerModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Image = i.Image ?? "JobPhoto.png",
                    Description = i.Description,
                    YayınTarihi = i.YayınTarihi,
                    GecerlilikTarihi = i.GecerlilikTarihi,
                    IsApproved = i.IsApproved,
                    IsHome = i.IsHome,
                    Description50 = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description

                }).ToList();

            return View(Etkinlik);
        }
        [Authorize(Roles = "user")]
        public ActionResult EtkinlikDetail(int id)
        {
            var Etkinlik = _context.Etkinliklers
                .Where(i => i.Id == id)
                .Select(i => new EtkinliklerModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Image = i.Image ?? "JobPhoto.png",
                    Description = i.Description,
                    YayınTarihi = i.YayınTarihi,
                    GecerlilikTarihi = i.GecerlilikTarihi,
                    Location = i.Location,
                    IsApproved = i.IsApproved,
                    IsHome = i.IsHome,
                    Description50 = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description

                }).FirstOrDefault();
            return View(Etkinlik);
        }
        [Authorize(Roles = "user")]
        public ActionResult Haberler()
        {
            return View();
        }
        [Authorize(Roles = "user")]
        public ActionResult Uyeler()
        {
            var Uyeler = _context.Users
                .Where(i => i.IsApproved)
                .Select(i => new UsersModel()
                {
                    Id = i.Id,
                    Username = i.Username,
                    UserLastName = i.UserLastName,
                    Image = i.Image ?? "JobPhoto.png",
                    Bolum = i.Bolum,
                    JobStatu = i.JobStatu,
                    Description = i.Description,
                    Description50 = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description
                }).ToList();
            return View(Uyeler);
        }
        [Authorize(Roles = "user")]
        public ActionResult UyelerProfil(int id)
        {
            var Uyeler = _context.Users
                .Where(i => i.Id == id)
                .Select(i => new UsersModel()
                {
                    Id = i.Id,
                    Username = i.Username,
                    UserLastName = i.UserLastName,
                    Image = i.Image ?? "JobPhoto.png",
                    Bolum = i.Bolum,
                    Job=i.Job,
                    MezunYıl = i.MezunYıl,
                    JobStatu = i.JobStatu,
                    Description = i.Description,
                    Description50 = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description

                }).FirstOrDefault();
            return View(Uyeler);
        }
        [Authorize(Roles = "user")]
        public ActionResult Job()
        {
            var Job = _context.Jobs
                .Where(i => i.IsApproved)
                .Select(i => new JobModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    JobName = i.JobName,
                    Image = i.Image ?? "JobPhoto.png",
                    Location = i.Location,
                    Description = i.Description,
                    Mail = i.Mail,
                    Tel = i.Tel,
                    YayınTarihi = i.YayınTarihi,
                    GecerlilikTarihi = i.GecerlilikTarihi,
                    Tür = i.Tür,
                    Sender = i.Sender,
                    IsApproved = i.IsApproved,
                    IsHome = i.IsHome,
                    Description50 = i.Description.Length>50?i.Description.Substring(0,47)+"...":i.Description

                }).ToList();
            return View(Job);
        }
        [Authorize(Roles = "user")]
        public ActionResult Gruplar()
        {

            return View(_context.Kategoriler.ToList());
        }
        [Authorize(Roles = "user")]
        public ActionResult GruplarDetail(int id)
        {
            BlogModelCotegoryModel Main = new BlogModelCotegoryModel();

            //var Uyeler = _context.Users
            //    .Where(i => i.Id == id)
            //    .Select(i => new UsersModel()
            //    {
            //        Id = i.Id,
            //        Username = i.Username,
            //        UserLastName = i.UserLastName,
            //        Image = i.Image ?? "JobPhoto.png",
            //        Bolum = i.Bolum,
            //        Job = i.Job,
            //        MezunYıl = i.MezunYıl,
            //        JobStatu = i.JobStatu,
            //        Description = i.Description,
            //        Description50 = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description

            //    }).FirstOrDefault();

            Main.Category = _context.Kategoriler.Where(i=>i.Id== id).Select(i => new CategoryModel()
            {
                Id = i.Id,
               Image = i.Image,
               KategoriAdi = i.KategoriAdi,

            }).ToList();
            Main.UsersModels = _context.Users.Where(i => i.IsApproved && i.IsHome).Select(i => new UsersModel()
            {

                Id = i.Id,
                Username = i.Username,
                UserLastName = i.UserLastName,
                Image = i.Image ?? "JobPhoto.png",
                Bolum = i.Bolum,
                Job = i.Job,
                JobStatu = i.JobStatu,
                Description = i.Description,
                Description50 = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description

            }).ToList();


     
            Main.Blogs = _context.Bloglar.Where(i => i.Onay && i.CategoryId==id).Select(i => new BlogsModel()
            {
                Id = i.Id,
                Image = i.Image ?? "JobPhoto.png",
                Baslik = i.Baslik.Length > 100 ? i.Baslik.Substring(0, 100) + "..." : i.Baslik,
                Aciklama = i.Aciklama.Length > 100 ? i.Aciklama.Substring(0, 100) + "..." : i.Aciklama,
                EklenmeTarihi = i.EklenmeTarihi,
                Icerik = i.Icerik,
                Icerik50 = i.Icerik.Length > 50 ? i.Icerik.Substring(0, 50) + "..." : i.Icerik,
                UsersId = i.UsersId,
                CategoryId = i.CategoryId

            }).ToList();
            return View(Main);
        }

        [Authorize(Roles = "user")]
        public ActionResult Album()
        {
            return View(_context.Albums.ToList());
        }
        [Authorize(Roles = "user")]
        public ActionResult PaylasimlarCreate()
        {
            ViewBag.CategoryId = new SelectList(_context.Kategoriler, "Id", "KategoriAdi");
            ViewBag.UsersId = new SelectList(_context.Users, "Id", "Username");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PaylasimlarCreate([Bind(Include = "Id,Baslik,Aciklama,Image,Icerik,EklenmeTarihi,Onay,AnaSayfa,CategoryId,UsersId")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                _context.Bloglar.Add(blog);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(_context.Kategoriler, "Id", "KategoriAdi", blog.CategoryId);
            ViewBag.UsersId = new SelectList(_context.Users, "Id", "Username", blog.UsersId);
            return View(blog);
        }
        [Authorize(Roles = "user")]
        public ActionResult Paylasimlar()
        {
            BlogsModelPaylas Main = new BlogsModelPaylas();
            Main.Blogs = _context.Bloglar.Where(i => i.Onay).Select(i=>new BlogsModel()
                {
                    Id = i.Id,
                    Image = i.Image ?? "JobPhoto.png",
                    Baslik = i.Baslik.Length > 100 ? i.Baslik.Substring(0, 100) + "..." : i.Baslik,
                    Aciklama = i.Aciklama.Length > 100 ? i.Aciklama.Substring(0, 100) + "..." : i.Aciklama,
                    EklenmeTarihi = i.EklenmeTarihi,
                    Icerik = i.Icerik,
                    Icerik50 = i.Icerik.Length > 50 ? i.Icerik.Substring(0, 50) + "..." : i.Icerik,
                    UsersId = i.UsersId,
                    CategoryId = i.CategoryId
            }).ToList();
            Main.UsersModels = _context.Users.Where(i => i.IsApproved && i.IsHome).Select(i => new UsersModel()
            {

                Id = i.Id,
                Username = i.Username,
                UserLastName = i.UserLastName,
                Image = i.Image ?? "JobPhoto.png",
                Bolum = i.Bolum,
                Job = i.Job,
                JobStatu = i.JobStatu,
                Description = i.Description,
                Description50 = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description

            }).ToList();
            return View(Main);
        }

    }
}