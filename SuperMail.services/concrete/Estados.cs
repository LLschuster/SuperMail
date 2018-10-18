using SuperMail.core.interfaces;
using SuperMail.core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperMail.services.concrete
{
    public class Estados : Iestados
    {
        MensajeContext context;
        public Estados(MensajeContext context)
        {
            this.context = context;
        }
        public void add(estado entity)
        {
            throw new NotImplementedException();
        }

        public void delete(estado entity)
        {
            throw new NotImplementedException();
        }

        public void edit(estado entity)
        {
            throw new NotImplementedException();
        }

        public estado findById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<estado> getAll()
        {
            return context.estados.AsEnumerable();
        }

        public string getEstadoName(int id)
        {
            var estado = context.estados.Find(id);
            return estado.descripcion.ToString();
        }
    }
}
