using PersonasMensajes.Clases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasMensajes.Servicios
{
    class PersonaServicio
    {
        public ObservableCollection<Persona> SacarPersonas()
        {
            ObservableCollection<Persona> personas = new ObservableCollection<Persona>();
            personas.Add(new Persona("Pietro", 30, "Italiana"));
            personas.Add(new Persona("Julia", 25, "Española"));
            personas.Add(new Persona("Sophie", 35, "Francesa"));
            return personas;
        }
    }
}
