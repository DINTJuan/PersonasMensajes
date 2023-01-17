using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using PersonasMensajes.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasMensajes.Mensajes
{
    class NuevaPersonaMessage : ValueChangedMessage<Persona>
    {
        public NuevaPersonaMessage(Persona nuevapersona) : base(nuevapersona)
        {

        }
    }
}
