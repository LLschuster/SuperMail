using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuperMail.core.models
{
    public class BaseEntity
    {
        [Key]
        public int id { get; set; }
        [Timestamp]
        public byte[] tiempoCreado { get; set; }
    }
}
