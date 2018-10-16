using SuperMail.core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperMail.Models
{
    public class MensajeViewModel
    {
        public IEnumerable<mensaje> mensajes { get; set; }
        public IEnumerable<estado> estados { get; set; }
    }
}