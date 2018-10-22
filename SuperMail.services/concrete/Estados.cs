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
        private readonly Irepository<estado> irepository;
        public Estados(Irepository<estado> irepository)
        {
            this.irepository = irepository;
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
            return irepository.getAll();
        }

        public string getEstadoName(int id)
        {
            var estado = irepository.findById(id);
            return estado.descripcion.ToString();
        }

        public void save()
        {
            throw new NotImplementedException();
        }
    }
}
