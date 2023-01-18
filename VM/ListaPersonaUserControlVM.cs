using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using PersonasMensajes.Clases;
using PersonasMensajes.Mensajes;
using PersonasMensajes.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasMensajes.VM
{
    class ListaPersonaUserControlVM : ObservableObject
    {
        private PersonaServicio personaservicio;
        private ObservableCollection<Persona> listaPersonas;
        private Persona personaSeleccionada;

        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { SetProperty(ref listaPersonas, value); }
        }
        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }
        }

        public ListaPersonaUserControlVM()
        {
            personaservicio = new PersonaServicio();
            ListaPersonas = personaservicio.SacarPersonas();
            WeakReferenceMessenger.Default.Register<PersonaSeleccionadaMessage>
                (this, (r, m) =>
                {
                    m.Reply(PersonaSeleccionada);
                });
            WeakReferenceMessenger.Default.Register<NuevaPersonaMessage>
                (this, (r, m) =>
                {
                    listaPersonas.Add(m.Value);
                });
            

        }
        
    }
}
