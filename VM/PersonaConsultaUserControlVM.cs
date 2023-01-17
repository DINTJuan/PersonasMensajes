using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using PersonasMensajes.Clases;
using PersonasMensajes.Mensajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasMensajes.VM
{
    class PersonaConsultaUserControlVM : ObservableRecipient
    {
        private Persona personaSeleccionada;
        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }
        }
        public PersonaConsultaUserControlVM()
        {
            PersonaSeleccionada = WeakReferenceMessenger.Default.Send<PersonaSeleccionadaMessage>();
        }
    }
}
