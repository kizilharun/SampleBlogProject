﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreProject.ViewComponents.Writer
{
    public class WriterMessageNotifications : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
