using SuperMail.core.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMail.core.interfaces
{
    public interface Irepository<T> where T : BaseEntity
    {
        IEnumerable<T> getAll();
        void add(T entity);
        void edit(T entity);
        void delete(T entity);
    }
}
