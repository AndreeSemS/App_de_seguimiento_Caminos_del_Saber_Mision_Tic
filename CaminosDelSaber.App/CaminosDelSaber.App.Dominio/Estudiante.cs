namespace CaminosDelSaber.App.Dominio
{
    public class Estudiante:Persona
    {
        public string Direccion {get; set;}
        public string Latitud {get; set;}
        public string Longitud {get; set;}
        public string Edad {get; set;}
        public string Grado {get; set;}
        public List<Materia> Materias {get; set;}
        public Acudiente Acudiente {get; set;}
        public List<Profesor> Profesores {get; set;}
        public List<Actividades> Actividades {get; set;}
        public List<Recomendaciones> Recomendaciones {get; set;}
    }
}