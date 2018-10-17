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
        private readonly Iestados iestados;
        public MensajeController()
        {

        }
        public MensajeController(IMensajes imensajes, Iestados iestados)
        {
            this.imensajes = imensajes;
            this.iestados = iestados;
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

       public ActionResult Detail(int id)
        {
            var men = imensajes.findById(id);
            MensajeViewModel viewModel = new MensajeViewModel
            {
                contenido = men.contenido,
                destinatario = men.destinatario,
                estado = iestados.getEstadoName(men.estadoID)
            };
            return View(viewModel);
        }
    }
}