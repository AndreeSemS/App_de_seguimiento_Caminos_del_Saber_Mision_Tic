namespace CaminosDelSaber.App.Dominio{

    public class Estudiante{

        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Telefono {get; set;}
        public string Usuario {get; set;}
        public Genero Genero {get; set;}
        public Rol Rol {get; set;}
        public string Direccion {get; set;}
        public string Edad {get; set;}
        public string Grado {get; set;}
        //public List<Asignatura> Materias {get; set;}
        public int AcudienteId {get; set;} //Llave foranea
        public Acudiente Acudiente {get; set;}
        public int TutorId {get; set;}
        public Tutor Tutor {get; set;}
        public int DocenteId {get; set;} //Llave foranea
        public Docente Docente {get; set;}
    }
}