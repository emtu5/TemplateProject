namespace net_project.Models
{
    public class RelatieProfesorMaterie
    {
        public Guid ProfesorId { get; set; }
        public Profesor Profesor { get; set; }
        public Guid MaterieId { get; set; }
        public Materie Materie { get; set; }
    }
}
