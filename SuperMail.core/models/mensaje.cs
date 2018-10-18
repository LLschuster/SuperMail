﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuperMail.core.models
{
    public class mensaje : BaseEntity
    {
        [Required]
        public string contenido { get; set; }
        [Required]
        public string destinatario { get; set; }
        [ForeignKey("estadoID")]
        public virtual estado estados { get; set; }
        public int estadoID { get; set; }
    }
}
