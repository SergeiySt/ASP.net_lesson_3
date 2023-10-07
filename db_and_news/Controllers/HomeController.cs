using db_and_news.Models;
using db_and_news.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace db_and_news.Controllers
{
    public class HomeController : Controller
    {
     //   private readonly ILogger<HomeController> _logger;

        private readonly EmailService _emailService;


        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}


        public HomeController(EmailService emailService)
        {
            _emailService = emailService;
        }

        public IActionResult Subscribe(string email, string newsTitle)
        {
            var subject = "Подписка на новости";
            var body = "Вы успешно подписались на наши новости.";

            var emailData = new EmailData
            {
                Email = email,
                NewsTitle = newsTitle
            };

            if (_emailService.SendEmail(email, subject, body, emailData))
            {
                return RedirectToAction("ThankYou");
            }
            else
            {
                ViewBag.ErrorMessage = "Произошла ошибка при отправке письма.";
                return View();
            }
        }
        public IActionResult Index()
        {
            //var users = ADbContext.Users.ToList();
            //return View();
            using (var context = new ADbContext()) 
            {
                var users = context.Users.ToList(); 

                return View(users); 
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}