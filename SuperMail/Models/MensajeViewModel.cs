using SuperMail.core.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuperMail.Models
{
    public class MensajeViewModel
    {
        public int id { get; set; }
        [Required]
        public string contenido { get; set; }
        [Required]
        public string destinatario { get; set; }
        public byte[] TiempoCreado { get; set; }
        public int estadoID { get; set; }
        public string estado { get; set; }
        public IEnumerable<mensaje> mensajes { get; set; }
        public IEnumerable<estado> estados { get; set; }
    }
}