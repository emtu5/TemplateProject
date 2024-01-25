using net_project.Models.Base;

namespace net_project.Models
{
    public class Materie : BaseEntity
    {
        public string Denumire { get; set; }
        public double NotaTrecere { get; set; }
        public int OreSaptamana { get; set; }
        public ICollection<RelatieProfesorMaterie> Relatii { get; set; }
    }
}
