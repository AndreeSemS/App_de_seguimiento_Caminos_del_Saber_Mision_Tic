using System;

namespace CaminosDelSaber.App.Dominio
{
    public class Persona
    {
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Telefono {get; set;}
        public string Correo {get; set;}
        public Genero Genero {get; set;}
        public Rol Rol {get; set;}
    }

}