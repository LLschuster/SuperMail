using SuperMail.core.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMail.core.interfaces
{
    public interface IMensajes
    {
        IEnumerable<mensaje> GetAllMensajes();
        void EnviarMensaje();
    }
}
