using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace studentsapp.Models
{
    public class Profesor
    {
        public Profesor()
        {
            ProfesorMaterias = new HashSet<ProfesorMateria>();
        }

        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public ICollection<ProfesorMateria> ProfesorMaterias { get; set; }
    }
}
