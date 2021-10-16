using System.Linq;
using System.Collections.Generic;

namespace CaminosDelSaber.App.Dominio{

    public class Docente{

        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Telefono {get; set;}
        public string Usuario {get; set;}
        public Genero Genero {get; set;}
        public Rol Rol {get; set;}
        public Estudiante Estudiante {get; set;} // Para llave foranea
        public int ActividadId {get; set;} //Llave foranea
        public Actividad Actividad {get; set;}
    }
}