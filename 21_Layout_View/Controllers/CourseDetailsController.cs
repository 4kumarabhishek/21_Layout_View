using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _21_Layout_View.Controllers
{
    public class CourseDetailsController : Controller
    {
        // GET: CourseDetails
        public ViewResult Dotnet()
        {
            return View();
        }

        public ViewResult PHP()
        {
            return View();
        }

        //If contents are same but alignment is different for different pages, then we go for Parial View (Static & Dynamic)

        //Demo for DYNAMIC PARTIAL VIEW-----
        //whenever we are going to create a dynamic partial view, we have to create one action method like the following having return Type PartialViewResult

        [ChildActionOnly]   //not necessary to mark my action as this -> but in that case if we give call to the below method directly, it will not be accessible -> it will be only accessible directly if we remove this attribute -> but if it is present, then we can call it within a view only
        public PartialViewResult SideBar()
        {
            string[] courses = { "PHP", "Java", "CSharp", "Cpp" };
            return PartialView("_SideBar", courses);
        }
    }
}