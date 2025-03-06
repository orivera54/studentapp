using Microsoft.EntityFrameworkCore;
using studentsapp.Models;

namespace studentsapp.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<EstudianteMateria> EstudianteMaterias { get; set; }
        public DbSet<ProfesorMateria> ProfesorMaterias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EstudianteMateria>()
                .HasKey(em => new { em.EstudianteId, em.MateriaId });

            modelBuilder.Entity<EstudianteMateria>()
                .HasOne(em => em.Estudiante)
                .WithMany(e => e.EstudianteMaterias)
                .HasForeignKey(em => em.EstudianteId);

            modelBuilder.Entity<EstudianteMateria>()
                .HasOne(em => em.Materia)
                .WithMany(m => m.EstudianteMaterias)
                .HasForeignKey(em => em.MateriaId);

            modelBuilder.Entity<ProfesorMateria>()
                .HasKey(pm => new { pm.ProfesorId, pm.MateriaId });

            modelBuilder.Entity<ProfesorMateria>()
                .HasOne(pm => pm.Profesor)
                .WithMany(p => p.ProfesorMaterias)
                .HasForeignKey(pm => pm.ProfesorId);

            modelBuilder.Entity<ProfesorMateria>()
                .HasOne(pm => pm.Materia)
                .WithMany(m => m.ProfesorMaterias)
                .HasForeignKey(pm => pm.MateriaId);
        }
    }
}
