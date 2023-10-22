using System.ComponentModel.DataAnnotations;
#nullable disable
namespace MVC.Entitties;

public class Resource
{
    public int Id { get; set; }

    public string Guid { get; set; }

    [Required]
    [StringLength(200)]
    public string Title { get; set; }

    [Required]
    public string Content { get; set; }

    public double? Score { get; set; }

    public DateOnly Date { get; set; }

    public List<UserResource> UserResources { get; set; }

}
