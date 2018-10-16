using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuperMail.core.models
{
    public class mensaje
    {
        [Key]
        public int id { get; set; }
        public string contenido { get; set; }
        public string destinatario { get; set; }
        
        public virtual estado estados { get; set; }
    }
}
