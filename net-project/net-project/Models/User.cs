using net_project.Models.Base;

namespace net_project.Models
{
    public class User : BaseEntity
    {
        public required string UserName { get; set; }
        public DateTime? Birthday { get; set;}
        public int Highscore { get; set;}
        public int Medals { get; set;}
    }
}
