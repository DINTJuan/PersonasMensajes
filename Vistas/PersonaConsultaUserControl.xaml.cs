using PersonasMensajes.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonasMensajes.Vistas
{
    /// <summary>
    /// Lógica de interacción para PersonaConsultaUserControl.xaml
    /// </summary>
    public partial class PersonaConsultaUserControl : UserControl
    {
        private PersonaConsultaUserControlVM vm;
        public PersonaConsultaUserControl()
        {
            InitializeComponent();
            this.vm = new PersonaConsultaUserControlVM();
            this.DataContext = vm;
        }
    }
}
