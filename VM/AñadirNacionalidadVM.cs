using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using PersonasMensajes.Mensajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasMensajes.VM
{
    class AñadirNacionalidadVM : ObservableObject
    {
        private string ncd;

        public string Ncd
        {
            get { return ncd; }
            set { SetProperty(ref ncd, value); }
        }

        public AñadirNacionalidadVM()
        {

        }

        public void AñadirNuevaNacionalidad()
        {
            WeakReferenceMessenger.Default.Send<AñadirNuevaNacionalidadMessage>(new AñadirNuevaNacionalidadMessage(this.Ncd));

        }
    }
}
