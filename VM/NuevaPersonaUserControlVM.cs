using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using PersonasMensajes.Clases;
using PersonasMensajes.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasMensajes.VM
{
    class NuevaPersonaUserControlVM : ObservableObject
    {
        private NavegacionServicio navegacion;
        private Persona nuevaPersona;
        private ObservableCollection<string> listaNacionalida;

        public Persona NuevaPersona
        {
            get { return nuevaPersona; }
            set { SetProperty(ref nuevaPersona, value); }
        }

        public ObservableCollection<string> ListaNacionalida
        {
            get { return listaNacionalida; }
            set { SetProperty(ref listaNacionalida, value); }
        }

        public RelayCommand NuevaNacionalidadCommand { get; }
        public RelayCommand AceptarNPersonaCommand { get; }

        public NuevaPersonaUserControlVM()
        {
            navegacion = new NavegacionServicio();
            NuevaPersona = new Persona();
            ObservableCollection<string> lista = new ObservableCollection<string>();
            lista.Add("Italiana");
            lista.Add("Española");
            lista.Add("Francesa");
            ListaNacionalida = lista;
            NuevaNacionalidadCommand = new RelayCommand(AñadirNacionalidad);
            AceptarNPersonaCommand = new RelayCommand(AceptarNuevaPersona);
        }

        public void AñadirNacionalidad()
        {
            navegacion.AbrirNacionalidad();
        }

        public void AceptarNuevaPersona()
        {
            // Añadiria a la nueva Persona
        }
    }
}
