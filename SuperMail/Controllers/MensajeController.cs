using SuperMail.core.interfaces;
using SuperMail.core.models;
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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(MensajeViewModel viewModel)
        {
            if (viewModel != null)
            {
                mensaje men = new mensaje
                {
                    contenido = viewModel.contenido,
                    destinatario = viewModel.destinatario,
                    estadoID = 1
                };
                imensajes.add(men);
            }
            return RedirectToAction("index");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}