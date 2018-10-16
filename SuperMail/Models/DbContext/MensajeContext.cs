using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace SuperMail.core.models
{
    public class MensajeContext : DbContext
    {
        public MensajeContext():
            base("MensajeContext"){
        }
        public DbSet<mensaje> mensajes { get; set; }
        public DbSet<estado> estados { get; set; }
    }
}

