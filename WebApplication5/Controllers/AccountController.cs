using Microsoft.AspNetCore.Mvc;

using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class AccountController : Controller
    {
        private readonly Trainee_MVP_CodeColoniesContext _dbcontext;
        public AccountController(Trainee_MVP_CodeColoniesContext context)
        {
            _dbcontext = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()              
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _dbcontext.MUsers.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
                if (user != null)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    Console.WriteLine("errp");
                    return View();
                }


            }
            return View();
        }
    }
}
