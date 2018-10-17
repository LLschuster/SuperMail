using SuperMail.core.interfaces;
using SuperMail.core.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SuperMail.services.concrete
{
    public class Mensajes : IMensajes
    {
        private MensajeContext context;
        public Mensajes (MensajeContext context){
            this.context= context;
        }
        public void EnviarMensaje(int id, string status)
        {
            var menj = context.mensajes.First(m=>m.id==id);
            if (status.Equals("Exito"))
            {
                menj.estadoID = 2;
            } else { menj.estadoID = 3; }
            context.SaveChanges();
        }

        
        public void add(mensaje mensaje)
        {
            context.mensajes.Add(mensaje);
            context.SaveChanges();
        }

        public IEnumerable<mensaje> getAll()
        {
            return context.mensajes.AsEnumerable();
        }

        public void edit(mensaje entity)
        {
            
        }

        public void delete(mensaje entity)
        {
            context.mensajes.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<mensaje> GetAllMensajes()
        {
            return context.mensajes.AsEnumerable();
        }

        public mensaje findById(int id)
        {
            return context.mensajes.First(m => m.id == id);
        }
    }
}
