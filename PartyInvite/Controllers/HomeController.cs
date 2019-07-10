using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvite.Models;

namespace PartyInvite.Controllers {
    public class HomeController : Controller
    {
        /* When I return a ViewResult object from an action method, I am instructing MVC to render a view. I
        create the ViewResult object by calling the View method, specifying the name of the view that I want to use,
        which is MyView.If you run the application, you can see MVC trying to find the view, as shown in the error
        message displayed
        */
       public ViewResult Index(){
            return View("MyView");
        }
    }
}
