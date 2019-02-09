using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenda.Models
{
    public class AgendaVM : Controller
    {
        // GET: AgendaVM
        public ActionResult Index()
        {
            return View();
        }
    }
}