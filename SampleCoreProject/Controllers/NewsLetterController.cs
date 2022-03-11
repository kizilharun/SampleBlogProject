using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreProject.Controllers
{
    public class NewsLetterController : Controller
    {
        public PartialViewResult SubscribeMail()
        {
            return View();
        }
        [HttpPost]

    }
}
