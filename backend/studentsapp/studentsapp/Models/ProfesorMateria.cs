namespace studentsapp.Models
{
    public class ProfesorMateria
    {
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
    }
}
