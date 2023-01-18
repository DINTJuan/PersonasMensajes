﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PersonasMensajes
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        //Register Syncfusion license
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(PersonasMensajes.Properties.Settings.Default.SFLicencia);
        }
        
    }
}
