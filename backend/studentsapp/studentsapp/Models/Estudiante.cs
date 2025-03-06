using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace studentsapp.Models
{
    public class Estudiante
    {
        public Estudiante()
        {
            EstudianteMaterias = new HashSet<EstudianteMateria>();
        }

        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public ICollection<EstudianteMateria> EstudianteMaterias { get; set; }
    }
}
