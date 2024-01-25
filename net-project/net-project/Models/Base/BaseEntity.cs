using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace net_project.Models.Base
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime? DateTime { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
