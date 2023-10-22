using System.ComponentModel.DataAnnotations;
#nullable disable
namespace MVC.Entitties;

public class Role
{
    public int Id { get; set; }

    public string Guid { get; set; }

    [Required]
    [StringLength(15)]
    public string Name { get; set; }

    //public ICollection<User> Users { get; set; }
    //public IEnumerable<User> Users { get; set; }
    //public IList<User> Users { get; set; }
    public List<User> Users { get; set; }
}
