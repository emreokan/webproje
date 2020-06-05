using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mezunlar.Identity;
using mezunlar.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;

namespace mezunlar.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> UserManager;
        private RoleManager<ApplicationRole> RoleManager;

        public AccountController()
        {
            var userStore = new UserStore<ApplicationUser>(new IdentityDataContext());
            UserManager= new UserManager<ApplicationUser>(userStore);
            var roleStore = new RoleStore<ApplicationRole>(new IdentityDataContext());
            RoleManager= new RoleManager<ApplicationRole>(roleStore);
        }
     
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Register model)
        {
            if (ModelState.IsValid)
            {
                //Kayıt İşlemleri
                ApplicationUser user =new ApplicationUser();
                user.Name = model.Name;
                user.SurName = model.Surname;
                user.Email = model.Email;
                user.UserName = model.UserName;
                
                var result = UserManager.Create(user, model.Password);
                if (result.Succeeded)
                {
                    //kullanıcı olustu ve kullanıcıyı bir role atayabilirim
                    if (RoleManager.RoleExists("user"))
                    {
                        UserManager.AddToRole(user.Id, "user");
                    }

                    return RedirectToAction("Login", "Account");
                }
                else
                {
                    ModelState.AddModelError("RegisterUserError","Kullanıcı oluşturma hatası");
                }
            }
            return View(model);
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Login model,string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                //login İşlemleri
              var user = UserManager.Find(model.UserName, model.Password);
              if (user!=null)
              {
                  //varolan kullanıcıyı sisteme dahil et
                  //ApplicationCookie olusturup sisteme bırak
                  var autManager = HttpContext.GetOwinContext().Authentication;
                  var identityclaims = UserManager.CreateIdentity(user, "ApplicationCookie");
                  var authProperties = new AuthenticationProperties();
                  authProperties.IsPersistent = model.RememberMe;
                  autManager.SignIn(authProperties, identityclaims);

                  if (String.IsNullOrEmpty(ReturnUrl))
                  {
                        //Redirect(ReturnUrl);
                        return RedirectToAction("Index", "Home");
                    }
                  return RedirectToAction("Index", "Home");
              }
              else
              {
                  ModelState.AddModelError("LoginUserError", "Böyle bir kullanıcı yok");
                }

            }
            return View(model);
        }
        public ActionResult Logout()
        {
            var autManager = HttpContext.GetOwinContext().Authentication;
            autManager.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}