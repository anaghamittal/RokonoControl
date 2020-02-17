﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Rokono_Control.DatabaseHandlers;
using Rokono_Control.Models;
using RokonoControl.Models;

namespace Rokono_Control.Controllers
{
    public class AccountsController : Controller
    {
        RokonoControlContext Context;
        public AccountsController(RokonoControlContext context)
        {
            Context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManageProjectMemebers(int projectId)
        {
            var currentUser = this.User;
            var currentUserId = currentUser.Claims.ElementAt(1);
            var rights = currentUser.Claims.LastOrDefault().Value;
            ViewData["ProjectId"] = projectId;
            ViewData["IsAdmin"] = int.Parse(rights) == 1 ? true : false;

            using (var context = new DatabaseController(Context))
            {
                ViewData["Relationships"] = context.GetProjectRelationships();
                ViewData["Branches"] = context.GetBranchesForProject(projectId);
                ViewData["Projects"] = context.GetUserProjects(int.Parse(currentUserId.Value));
                ViewData["DefaultIteration"] = context.GetProjectDefautIteration(projectId);
            }
            return View();
        }
        
        [HttpPost]
        public string AssociateNewUserAccount([FromBody] IncomingProjectAccount projectAccount)
        {
            using(var context = new DatabaseController(Context))
            {
                context.AddProjectInvitation(projectAccount);
            }
            return "Success";
        }

        [HttpPost] 
        public string AssociateMembers([FromBody] IncomingExistingProjectMembers accounts)
        {
            using(var context  = new DatabaseController(Context))
            {
                context.AssociatedProjectExistingMembers(accounts);
            }
            return  "Ok";
        }
    }
}