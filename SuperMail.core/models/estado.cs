using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SuperMail.core.models
{
   public class estado
    {
        [Key]
        public int id { get; set; }
        public string descripcion { get; set; }
    }
}
