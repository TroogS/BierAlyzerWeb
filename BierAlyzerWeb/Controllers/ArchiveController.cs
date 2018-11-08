﻿using BierAlyzerWeb.Helper;
using BierAlyzerWeb.Models.Archive;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using Contracts.Model;

namespace BierAlyzerWeb.Controllers
{
    public class ArchiveController : Controller
    {
        /// <summary>   Executes the action executing action. </summary>
        /// <param name="context">  The context. </param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.IsSignedIn())
            {
                context.Result = RedirectToAction("Login", "Account");
                return;
            }

            base.OnActionExecuting(context);
        }

        /// <summary> Return all closed Events </summary>
        public IActionResult Archive()
        {
            var model = new ArchiveModel { User = HttpContext.GetUser() };
            using (var context = ContextHelper.OpenContext())
            {
                model.Events = context.GetUserEvents(model.User.UserId)
                    .Where(x => x.Status == EventStatus.Closed)
                    .ToList();
            }
            return View(model);
        }
    }
}