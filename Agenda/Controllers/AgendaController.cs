using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenda.Controllers
{
    public class AgendaController : Controller
    {
        [Route("Agenda")]
        public ActionResult Index()
        {
            return View();
        }
    }
}