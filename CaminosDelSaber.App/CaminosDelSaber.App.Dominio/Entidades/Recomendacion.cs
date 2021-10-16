namespace CaminosDelSaber.App.Dominio{

    public class Recomendacion{
        
        public int Id {get; set;}
        public string Descripcion {get; set;}
        public Tutor Tutor {get; set;} // Para la llave foranea
    }
}