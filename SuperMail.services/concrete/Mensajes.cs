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
        private readonly Irepository<mensaje> irepository;
        public Mensajes (Irepository<mensaje> irepository)
        {
            this.irepository = irepository;
        }
        public void EnviarMensaje(int id, string status)
        {
            var menj = irepository.findById(id);
            if (status.Equals("Exito"))
            {
                menj.estadoID = 2;
            } else { menj.estadoID = 3; }
            irepository.update();
        }

        
        public void add(mensaje mensaje)
        {
            irepository.add(mensaje);
        }

        public IEnumerable<mensaje> getAll()
        {
            return irepository.getAll().AsEnumerable();
        }


        public void delete(mensaje entity)
        {
            irepository.delete(entity);
        }

        public mensaje findById(int id)
        {
            return irepository.findById(id);
        }

        public IEnumerable<mensaje> GetMensajesByCategory(int id)
        {
            return irepository.getAll().Where(x=>x.estadoID==id).AsEnumerable();
        }

        public void update()
        {
            irepository.update();
        }
    }
}
