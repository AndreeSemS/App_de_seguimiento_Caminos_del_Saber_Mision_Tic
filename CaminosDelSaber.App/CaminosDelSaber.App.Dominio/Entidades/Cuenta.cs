namespace CaminosDelSaber.App.Dominio{

    public class Cuenta{
        
        public int Id {get; set;}
        public string Usuario {get; set;}
        public string Contraseña {get; set;}
        public Rol Rol {get; set;}
    }
}