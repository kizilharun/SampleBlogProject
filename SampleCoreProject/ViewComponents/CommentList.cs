using Microsoft.AspNetCore.Mvc;
using SampleCoreProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleCoreProject.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    UserName ="harun"
                },
                new UserComment
                {
                    Id= 2,
                    UserName="alattin"
                },
                new UserComment
                {
                    Id=3,
                    UserName="onur"
                }
            };
            return View(commentValues);
        }
    }
}
