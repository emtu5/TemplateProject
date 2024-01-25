using net_project.Models.Base;
using net_project.Models.Enums;

namespace net_project.Models
{
    public class Profesor : BaseEntity
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Email { get; set; }
        public RolProfesor Rol { get; set; }
        public ICollection<RelatieProfesorMaterie> Relatii { get; set; }
    }
}
