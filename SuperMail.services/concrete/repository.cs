using SuperMail.core.interfaces;
using SuperMail.core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperMail.services.concrete
{
    public class repository<T> : Irepository<T> where T : BaseEntity
    {
        private readonly MensajeContext mensajeContext;
        public repository(MensajeContext mensajeContext)
        {
            this.mensajeContext = mensajeContext;
        }
        public void add(T entity)
        {
            if (entity != null)
            {
                mensajeContext.Set<T>().Add(entity);
                mensajeContext.SaveChanges();
            } else
            {
                throw new ArgumentNullException();
            }
        }

        public void delete(T entity)
        {
            if (entity != null)
            {
                mensajeContext.Set<T>().Remove(entity);
                mensajeContext.SaveChanges();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public void edit(T entity)
        {
            mensajeContext.SaveChanges();
        }

        public IEnumerable<T> getAll()
        {
            return mensajeContext.Set<T>().AsEnumerable();
        }
    }
}
