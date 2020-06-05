using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mezunlar.entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var isler=new List<Job>()
            {
                new Job()
                {
                    Name = "Yazılım Uzmanı",
                    JobName = "Xena-Vision",
                    Location = "Ankara",
                    Description ="t is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                    Mail="emre@gmail.com",
                    Tel="05555555555",
                    GecerlilikTarihi = "02/05/2020",
                    YayınTarihi = "05/06/2019",
                    Sender = "emre tarı",
                    Image = "emre.jpg",
                    Tür = "iş",
                    IsApproved = true
                },
                new Job()
                {
                    Name = "Bilgisayar Mühendisi",
                    JobName = "Xena-Vision",
                    Location = "Ankara",
                    Description ="t is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                    Mail="okan@gmail.com",
                    Tel="05455555555",
                    GecerlilikTarihi = "02/05/2020",
                    YayınTarihi = "05/06/2019",
                    Sender = "Okan Kocatürk",
                    Image = "okan.jpeg",
                    Tür = "iş",
                    IsHome = true,
                    IsApproved = true
                },
                new Job()
                {
                    Name = "Veritabanı uzmanı",
                    JobName = "ASD Yazılım A.Ş.",
                    Location = "Ankara",
                    Description ="t is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                    Mail="emre@gmail.com",
                    Tel="05555555555",
                    GecerlilikTarihi = "02/05/2020",
                    YayınTarihi = "05/06/2019",
                    Sender = "Emre Tarı",
                    Image = "emre.jpg",
                    Tür = "iş",
                    IsHome = true,
                    IsApproved = true
                }
            };
            foreach (var islers in isler)
            {
                context.Jobs.Add(islers);
            }

            context.SaveChanges();

           var etkinliklers =new List<Etkinlikler>()
            {

                new Etkinlikler()
                {
                    Name = "Web Geliştirme Eğitimi",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                    YayınTarihi = "20.02.2020",
                    GecerlilikTarihi = "20.05.2020",
                    Image = "webdev.png",
                    Location = "Gazi Üniversitesi",
                    IsApproved = true,
                    IsHome = true

                },
                new Etkinlikler()
                {
                    Name = "Satranc Turnuvası",
                    Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                    YayınTarihi = "23.01.2020",
                    GecerlilikTarihi = "20.03.2020",
                    Image = "satranc.jpg",
                    Location = "Gazi Üniversitesi",
                    IsApproved = true,
                    IsHome = true
            },
                new Etkinlikler()
                {
                Name = "Futbol Turnuvası",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                YayınTarihi = "20.02.2019",
                GecerlilikTarihi = "20.05.2019",
                Image = "futbol.png",
                Location = "Gazi Üniversitesi Stadı",
                IsApproved = true,
                IsHome = false
            }

            };
           foreach (var etkinlik in etkinliklers)
           {
               context.Etkinliklers.Add(etkinlik);
           }

           context.SaveChanges();

            var albums = new List<Album>()
            {
                new Album()
                {
                    Name = "Gazi de Gündüz",
                    Image = "gaziüni.jpg",
                },
                new Album()
                {
                    Name = "Gazi de Gündüz 1",
                    Image = "gaziüni.jpg",
                },
                new Album()
                {
                    Name = "Gazi de Gündüz 2",
                    Image = "gaziüni.jpg",
                },
                new Album()
                {
                    Name = "Gazi de Gündüz 3",
                    Image = "gaziüni.jpg",
                },
                new Album()
                {
                    Name = "Gazi de Gündüz 4",
                    Image = "gaziüni.jpg",
                },
                new Album()
                {
                    Name = "Gazi de Gündüz 5",
                    Image = "gaziüni.jpg",
                },
                new Album()
                {
                    Name = "Gazi de Gündüz 6",
                    Image = "gaziüni.jpg",
                },
                new Album()
                {
                    Name = "Gazi de Gündüz 7",
                    Image = "gaziüni.jpg",
                },
                new Album()
                {
                    Name = "Gazi de Gündüz 8",
                    Image = "gaziüni.jpg",
                },
                new Album()
                {
                    Name = "Gazi de Gündüz 9",
                    Image = "gaziüni.jpg",
                },
            };
            foreach (var alb in albums)
            {
                context.Albums.Add(alb);
            }

            context.SaveChanges();

            var Usersa = new List<Users>()
            {
                new Users()
                {
                    Username = "okan",
                    UserLastName = "KOCATURK",
                    Mail = "okan@gmail.com",
                    Tel = "05455555555",
                    Adress = "Yenimahalle/ANKARA",
                    Image = "okan.jpeg",
                    Job = "Yazılım Mühendisi",
                    JobstartYear = 2020,
                    Fakulte = "Teknoloji",
                    Bolum = "Bilgisayar Mühendisliği",
                    IsHome = true,
                    IsApproved = true,
                    MezunOldumu = true,
                    MezunYıl = 2021,
                    Description = "Bilgisayar Mühendisliği Mezunu",
                    JobStatu = "Senior Developer"
                },
                new Users()
                {
                    Username = "emre",
                    UserLastName = "TARI",
                    Mail = "emre@gmail.com",
                    Tel = "05555555555",
                    Adress = "Sincan/ANKARA",
                    Image = "emre.jpg",
                    Job = "Bilgisayar Mühendisi",
                    JobstartYear = 2020,
                    Fakulte = "Teknoloji Fakültesi",
                    Bolum = "Bilgisayar Mühendisliği",
                    IsHome = true,
                    IsApproved = true,
                    MezunOldumu = true,
                    MezunYıl = 2021,
                    Description = "Bilgisayar Mühendisi Mezunu",
                    JobStatu = "Senior Developer"
                },
                new Users()
                {
                    Username = "Resul",
                    UserLastName = "AVŞAR",
                    Mail = "resul@gmail.com",
                    Tel = "05355555555",
                    Adress = "Yenimahalle/ANKARA",
                    Image = "okan.jpeg",
                    Job = "Yazılım Mühendisi",
                    JobstartYear = 2018,
                    Fakulte = "Elektrik-Elektronik Fakültesi",
                    Bolum = "Elektrik Mühendisliği",
                    IsHome = true,
                    IsApproved = true,
                    MezunOldumu = true,
                    MezunYıl = 2021,
                    Description = "Elektrik Mühendisliği Mezunu",
                    JobStatu = "Senior Developer"
                },
                
                new Users()
                {
                    Username = "Fatih",
                    UserLastName = "YILMAZ",
                    Mail = "fatih@gmail.com",
                    Tel = "05426204954",
                    Adress = "Sincan/ANKARA",
                    Image = "emre.jpg",
                    Job = "Yazılım Mühendisi",
                    JobstartYear = 2018,
                    Fakulte = "Elektrik-Elektronik Fakültesi",
                    Bolum = "Elektrik Mühendisliği",
                    IsHome = true,
                    IsApproved = true,
                    MezunOldumu = true,
                    MezunYıl = 2021,
                    Description = "Elektrik Mühendisliği Mezunu",
                    JobStatu = "Senior Developer"
                },

            };
            foreach (var user in Usersa)
            {
                context.Users.Add(user);
            }

            context.SaveChanges();
           
            var Kategoriler = new List<Category>()
            {
                new Category(){KategoriAdi = "Teknoloji Fakültesi",Image = "mühendis1.jpg"},
                new Category(){KategoriAdi = "Mühendislik Fakültesi",Image = "mühendis.jpg"},
                new Category(){KategoriAdi = "Tıp Fakültesi",Image = "tıp.png"},
                new Category(){KategoriAdi = "İletişim Fakültesi",Image = "iletişim.jpg"},
                new Category(){KategoriAdi = "Eğitim Fakültesi",Image = "egitim.jpg"},
                new Category(){KategoriAdi = "Fen Fakültesi",Image = "fen.jpg"},
                
            };
            foreach (var kategori in Kategoriler)
            {
                context.Kategoriler.Add(kategori);
            }
            context.SaveChanges();
            var Bloglar = new List<Blog>()
            {
                new Blog()
                {
                    Baslik = "Mezuniyet buluşması hakkında",
                    Aciklama = "Mezuniyet buluşması hakkında",
                    EklenmeTarihi = DateTime.Now.AddDays(-10),
                    AnaSayfa = true,
                    Onay = true,
                    Icerik = "Mezun buluşmasında, piknik etkinliği.",
                    Image = "gaziüni.jpg",
                    CategoryId = 1,
                    UsersId = 1

                },
                new Blog()
                {
                    Baslik = "Mezuniyet buluşması hakkında",
                    Aciklama = "Mezuniyet buluşması hakkında",
                    EklenmeTarihi = DateTime.Now.AddDays(-10),
                    AnaSayfa = true,
                    Onay = true,
                    Icerik = "Mezun buluşmasında, piknik etkinliği.",
                    Image = "gaziüni.jpg",
                    CategoryId = 1,
                    UsersId = 1
                },
                new Blog()
                {
                    Baslik = "Mezuniyet buluşması hakkında",
                    Aciklama = "Mezuniyet buluşması hakkında",
                    EklenmeTarihi = DateTime.Now.AddDays(-10),
                    AnaSayfa = true,
                    Onay = true,
                    Icerik = "Mezun buluşmasında, piknik etkinliği.",
                    Image = "gaziüni.jpg",
                    CategoryId = 2,
                    UsersId = 1
                },
                new Blog()
                {
                    Baslik = "Mezuniyet buluşması hakkında",
                    Aciklama = "Mezuniyet buluşması hakkında",
                    EklenmeTarihi = DateTime.Now.AddDays(-10),
                    AnaSayfa = true,
                    Onay = true,
                    Icerik = "Mezun buluşmasında, piknik etkinliği.",
                    Image = "gaziüni.jpg",
                    CategoryId = 2,
                    UsersId = 2
                },
                new Blog()
                {
                    Baslik = "Mezuniyet buluşması hakkında",
                    Aciklama = "Mezuniyet buluşması hakkında",
                    EklenmeTarihi = DateTime.Now.AddDays(-10),
                    AnaSayfa = true,
                    Onay = true,
                    Icerik = "Mezun buluşmasında, piknik etkinliği.",
                    Image = "gaziüni.jpg",
                    CategoryId = 2,
                    UsersId = 2
                },
                new Blog()
                {
                    Baslik = "Mezuniyet buluşması hakkında",
                    Aciklama = "Mezuniyet buluşması hakkında",
                    EklenmeTarihi = DateTime.Now.AddDays(-10),
                    AnaSayfa = true,
                    Onay = true,
                    Icerik = "Mezun buluşmasında, piknik etkinliği.",
                    Image = "gaziüni.jpg",
                    CategoryId = 2,
                    UsersId = 2
                },
                new Blog()
                {
                    Baslik = "Mezuniyet buluşması hakkında",
                    Aciklama = "Mezuniyet buluşması hakkında",
                    EklenmeTarihi = DateTime.Now.AddDays(-10),
                    AnaSayfa = true,
                    Onay = true,
                    Icerik = "Mezun buluşmasında, piknik etkinliği.",
                    Image = "gaziüni.jpg",
                    CategoryId = 3,
                    UsersId = 3
                },
                new Blog()
                {
                    Baslik = "Mezuniyet buluşması hakkında",
                    Aciklama = "Mezuniyet buluşması hakkında",
                    EklenmeTarihi = DateTime.Now.AddDays(-10),
                    AnaSayfa = true,
                    Onay = true,
                    Icerik = "Mezun buluşmasında, piknik etkinliği.",
                    Image = "gaziüni.jpg",
                    CategoryId = 3,
                    UsersId = 3
                },
                new Blog()
                {
                    Baslik = "Mezuniyet buluşması hakkında",
                    Aciklama = "Mezuniyet buluşması hakkında",
                    EklenmeTarihi = DateTime.Now.AddDays(-10),
                    AnaSayfa = true,
                    Onay = true,
                    Icerik = "Mezun buluşmasında, piknik etkinliği.",
                    Image = "gaziüni.jpg",
                    CategoryId = 3,
                    UsersId = 3
                },
                new Blog()
                {
                    Baslik = "Mezuniyet buluşması hakkında",
                    Aciklama = "Mezuniyet buluşması hakkında",
                    EklenmeTarihi = DateTime.Now.AddDays(-10),
                    AnaSayfa = true,
                    Onay = true,
                    Icerik = "Mezun buluşmasında, piknik etkinliği.",
                    Image = "gaziüni.jpg",
                    CategoryId = 4,
                    UsersId = 4
                },
                new Blog()
                {
                    Baslik = "Mezuniyet buluşması hakkında",
                    Aciklama = "Mezuniyet buluşması hakkında",
                    EklenmeTarihi = DateTime.Now.AddDays(-10),
                    AnaSayfa = true,
                    Onay = true,
                    Icerik = "Mezun buluşmasında, piknik etkinliği.",
                    Image = "gaziüni.jpg",
                    CategoryId = 4,
                    UsersId = 4
                },
                new Blog()
                {
                    Baslik = "Mezuniyet buluşması hakkında",
                    Aciklama = "Mezuniyet buluşması hakkında",
                    EklenmeTarihi = DateTime.Now.AddDays(-10),
                    AnaSayfa = true,
                    Onay = true,
                    Icerik = "Mezun buluşmasında, piknik etkinliği.",
                    Image = "gaziüni.jpg",
                    CategoryId = 4,
                    UsersId = 4
                },
            };

            foreach (var item in Bloglar)
            {
                context.Bloglar.Add(item);
            }

            context.SaveChanges();
            base.Seed(context);
        }
    }
}
 