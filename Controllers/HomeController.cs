using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<string> dojoLocations = new List<string>()
            {
                "Arlington",
                "Berkley", 
                "Boise",
                "Chicago",
                "Dallas",
                "Los Angeles",
                "Orange County",
                "San Jose",
                "Seattle",
                "Tulsa",
                "Online"
            };

            List<string> dojoLanguages = new List<string>()
            {
                "HTML",
                "CSS", 
                "JavaScript",
                "Python",
                "Java",
                "C#",
                "My Right Hand Named Tom"
            };

            ViewBag.locations = dojoLocations;
            ViewBag.languages = dojoLanguages;

            return View();
        }

        [HttpPost]
        [Route("SubmittedInfo")]
        public IActionResult SubmittedInfo(string yourDojoName, string yourDojoLocation, string yourDojoLanguage, string yourDojoComment)
        {
            ViewBag.Name = yourDojoName;
            ViewBag.Location = yourDojoLocation;
            ViewBag.Language = yourDojoLanguage;
            ViewBag.Comment = yourDojoComment;
            return View("SubmittedInfo");
        }
    }
}