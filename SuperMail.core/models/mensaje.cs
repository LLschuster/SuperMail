using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuperMail.core.models
{
    public class mensaje : BaseEntity
    {
        
        public string contenido { get; set; }
        public string destinatario { get; set; }
        public virtual estado estados { get; set; }
    }
}
