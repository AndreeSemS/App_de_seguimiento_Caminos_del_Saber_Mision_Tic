namespace CaminosDelSaber.App.Dominio{

    public class Acudiente{

        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Telefono {get; set;}
        public string Usuario {get; set;}
        public Genero Genero {get; set;}
        public Rol Rol {get; set;}
        public Estudiante Estudiante {get; set;} // Para la llave foranea
        public string Parentesco {get; set;}
    }
}