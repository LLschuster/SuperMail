using SuperMail.core.interfaces;
using SuperMail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperMail.Controllers
{
    public class MensajeController : Controller
    {
        private readonly IMensajes imensajes;
        public MensajeController(IMensajes imensajes)
        {
            this.imensajes = imensajes;
        }
        public ActionResult Index()
        {
            var allMensaje = imensajes.GetAllMensajes();
            MensajeViewModel mensajeView = new MensajeViewModel
            {
                mensajes = allMensaje
        };
        return View(mensajeView);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}