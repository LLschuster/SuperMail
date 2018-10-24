using SuperMail.core.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMail.core.interfaces
{
    public interface Irepository<T> where T : BaseEntity
    {
        IEnumerable<T> getAll();
        T findById(int id);
        void add(T entity);
        void delete(T entity);
        void update();
    }
}
