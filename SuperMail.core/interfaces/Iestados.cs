using SuperMail.core.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMail.core.interfaces
{
    public interface Iestados : Irepository<estado>
    {
        string getEstadoName(int id);
    }
}
