using MVC.Enum;
using System.ComponentModel.DataAnnotations;
using System.Data;
#nullable disable

namespace MVC.Entitties;

public class User
{
    public int Id { get; set; } // özellik (property)

    public string Guid { get; set; }

    [Required]
    [StringLength(10, MinimumLength = 3)]
    public string UserName { get; set; }

    [Required]
    [StringLength(10)]
    public string Password { get; set; }

    public bool IsActive { get; set; }

    public Statuses Status { get; set; }

    public DateTime? BirthDate { get; set; }

    public int RoleId { get; set; }

    public Role Role { get; set; }

    public List<UserResource> UserResources { get; set; }
}
