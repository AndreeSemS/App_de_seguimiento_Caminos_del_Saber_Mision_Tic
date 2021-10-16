namespace CaminosDelSaber.App.Dominio
{
    public class Actividad{
        
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Descripcion {get; set;}
        public Estado Estado {get; set;}
        public Docente Docente {get; set;} //Para la llave foranea
    }
}