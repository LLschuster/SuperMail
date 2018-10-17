using SuperMail.core.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMail.core.interfaces
{
    public interface IMensajes : Irepository<mensaje>
    {
        IEnumerable<mensaje> GetAllMensajes();
        void EnviarMensaje();
        
    }
}
