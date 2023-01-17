using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasMensajes.Mensajes
{
    class AñadirNuevaNacionalidadMessage : ValueChangedMessage<string>
    {
        public AñadirNuevaNacionalidadMessage(string nuevanacionalidad) : base(nuevanacionalidad)
        {

        }
    }
}
