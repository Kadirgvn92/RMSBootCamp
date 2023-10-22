using System.ComponentModel.DataAnnotations;
#nullable disable
namespace MVC.Entitties;

public class UserResource
{
    [Key]
    public int UserId { get; set; }

    public User User { get; set; }

    [Key]
    public int ResourceId { get; set; }

    public Resource Resource { get; set; }
}
