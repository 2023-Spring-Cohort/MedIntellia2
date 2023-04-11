
using MedIntellia.Models;
using Microsoft.AspNetCore.Mvc;
using Service_Broker.Public;
using Service_Broker.RapidAPI;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;

namespace MedIntellia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAdviceService advice;
        private readonly IRapidAPI_Countries country;

        public HomeController(ILogger<HomeController> logger, IAdviceService advice, IRapidAPI_Countries country)
        {
            _logger = logger;
            this.advice = advice;
            this.country = country;
        }

        public async Task<ActionResult> Index()
        {
            return View();
        }

        //[Route("Hospital/map4")]
        public async Task<ActionResult> Map4()
        {
            return View($"../Hospital/map4");

        }

        public async Task<ActionResult> Advice()
        {
            return View(await advice.GetAdviceAsync());
        }
        //public async Task<ActionResult> Countries()
        //{
        //    return View(await country.GetCountriesAsync());
        //}

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }
        public IActionResult LatestNews()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(SendMailDto sendMailDto)
        {
            if (!ModelState.IsValid) return View();
            try
            {
                MailMessage mail = new MailMessage();
                // you need to enter your mail address
                mail.From = new MailAddress("michaelakahotboy59@gmail.com");
                //To Email Address - your need to enter your to email address
                mail.To.Add("michael.javier.gonzalez@outlook.com");
                mail.Subject = sendMailDto.Subject;
                //you can specify also CC and BCC - i will skip this
                //mail.CC.Add("");
                //mail.Bcc.Add("");
                mail.IsBodyHtml = true;
                string content = "Name : " + sendMailDto.Name;
                content += "<br/> Message : " + sendMailDto.Message;
                content += "<br/> Email : " + sendMailDto.Email;
                mail.Body = content;
                //create SMTP instant
                //you need to pass mail server address and you can also specify the port number if you required
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                //Create nerwork credential and you need to give from email address and password
                NetworkCredential networkCredential = new NetworkCredential("michaelakahotboy59@gmail.com", "nsxvefbdyfqovguv");
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = networkCredential;
                smtpClient.Port = 587; // this is default port number - you can also change this
                smtpClient.EnableSsl = true; // if ssl required you need to enable it
                smtpClient.Send(mail);
                ViewBag.Message = "Email Sent Successfully";
                // now i need to create the from
                ModelState.Clear();
            }
            catch (Exception ex)
            {
                //If any error occured it will show
                ViewBag.Message = ex.Message.ToString();
            }
            return View();
        }
        //public IActionResult LogIn()
        //{
        //    return View();
        //}

        //public IActionResult Register()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}