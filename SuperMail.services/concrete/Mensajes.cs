using SuperMail.core.interfaces;
using SuperMail.core.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace SuperMail.services.concrete
{
    public class Mensajes : IMensajes
    {
        private MensajeContext db;
        public Mensajes (MensajeContext db){
            this.db = db;
        }
        public void EnviarMensaje()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<mensaje> GetAllMensajes()
        {
            return db.mensajes;
        }
    }
}
