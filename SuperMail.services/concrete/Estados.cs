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
            irepository.add(entity);
        }

        public void delete(estado entity)
        {
            irepository.delete(entity);
        }

        public estado findById(int id)
        {
          return  irepository.findById(id);
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

        public void update()
        {
            irepository.update();
        }
    }
}
