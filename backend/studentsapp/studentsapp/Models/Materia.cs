using System.ComponentModel.DataAnnotations;

namespace studentsapp.Models
{
    public class Materia
    {
        public Materia()
        {
            EstudianteMaterias = new HashSet<EstudianteMateria>();
            ProfesorMaterias = new HashSet<ProfesorMateria>();
        }

        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public ICollection<EstudianteMateria> EstudianteMaterias { get; set; }
        public ICollection<ProfesorMateria> ProfesorMaterias { get; set; }
    }
}
