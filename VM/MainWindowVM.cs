using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using PersonasMensajes.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PersonasMensajes.VM
{
    class MainWindowVM : ObservableObject
    {
        private UserControl contenidoVentana;
        public UserControl ContenidoVentana
        {
            get { return contenidoVentana; }
            set { SetProperty(ref contenidoVentana, value); }
        }
        private NavegacionServicio navegacion;

        public RelayCommand AbrirNPersonaCommand { get; }
        public RelayCommand AbrirLPersonaCommand { get; }

        public MainWindowVM()
        {
            navegacion = new NavegacionServicio();
            AbrirLPersonaCommand = new RelayCommand(AbrirListaPersona);
            AbrirNPersonaCommand = new RelayCommand(AbrirNuevaPersona);
        }

        public void AbrirNuevaPersona()
        {
            ContenidoVentana = navegacion.AbrirNuevaPersona();
        }

        public void AbrirListaPersona()
        {
            ContenidoVentana = navegacion.AbrirListaPersona();
        }
    }
}
