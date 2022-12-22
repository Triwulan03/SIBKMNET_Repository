using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIBKMNET_WebApp.Repositories.Data;
using SIBKMNET_WebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIBKMNET_WebApp.Context
{
    public class AccountController : Controller
    {
        AccountRepository accountRepository;

        public AccountController(AccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Login login)
        {
            var data = accountRepository.Login(login);
            if(data !=null)
            {
                HttpContext.Session.SetString("Role", data.Role);
                return RedirectToAction("Index", "Province");
            }

            return View();
        }
    }
}
