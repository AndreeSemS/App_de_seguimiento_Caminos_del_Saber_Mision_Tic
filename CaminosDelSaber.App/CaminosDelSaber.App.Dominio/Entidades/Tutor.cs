using System.Collections.Generic;

namespace CaminosDelSaber.App.Dominio{

    public class Tutor{
        
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Telefono {get; set;}
        public string Usuario {get; set;}
        public Genero Genero {get; set;}
        public Rol Rol {get; set;}
        public Estudiante Estudiante {get; set;} //Para la llave foranea
        //public List<Recomendacion> Recomenfaciones {get; set;}
        public int RecomendacionId {get; set;} //Llave foranea
        public Recomendacion Recomendacion {get; set;}
    }
}