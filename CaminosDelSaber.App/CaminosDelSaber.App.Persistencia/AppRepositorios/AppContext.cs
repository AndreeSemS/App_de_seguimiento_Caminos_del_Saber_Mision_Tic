using System.Linq;
using System.Collections.Generic;
using CaminosDelSaber.App.Dominio;
using Microsoft.EntityFrameworkCore;

namespace CaminosDelSaber.App.Persistencia{
    
    public class AppContext:DbContext{

        public DbSet<Cuenta> Cuentas {get; set;}
        public DbSet<Estudiante> Estudiantes {get; set;}
        public DbSet<Docente> Docentes {get; set;}
        public DbSet<Tutor> Tutores {get; set;}
        public DbSet<Acudiente> Acudientes {get; set;}
        public DbSet<Actividad> Actividades {get; set;}
        public DbSet<Recomendacion> Recomendaciones {get; set;}

        //Generar llaves foraneas en la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder){

            modelBuilder.Entity<Docente>()
                .HasOne(d => d.Estudiante)
                .WithOne(e => e.Docente)
                .HasForeignKey<Estudiante>(e => e.DocenteId);
 
            modelBuilder.Entity<Acudiente>()
                .HasOne(a => a.Estudiante)
                .WithOne(e => e.Acudiente)
                .HasForeignKey<EIstudiante>(e => e.Acudiented);

            modelBuilder.Entity<Tutor>()
                .HasOne(t => t.Estudiante)
                .WithOne(e => e.Tutor)
                .HasForeignKey<Estudiante>(e => e.TutorId);

            modelBuilder.Entity<Actividad>()
                .HasOne(a => a.Docente)
                .WithOne(d => d.Actividad)
                .HasForeignKey<Docente>(d => d.ActividadId);

            modelBuilder.Entity<Recomendacion>()
                .HasOne(r => r.Tutor)
                .WithOne(t => t.Recomendacion)
                .HasForeignKey<Tutor>(t => t.RecomendacionId);
        }
    
            //Link para conexión en Ubuntu
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer(
                    "Server=localhost; Database=CaminosDelSaber.App.Data; user=SA; password=raizdeTANGENTE18+; Trusted_Connection=False; MultipleActiveResultSets=True;");
            }
        }
    }
}