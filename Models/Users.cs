using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models;

public class UsersModel
{
    [Key]
    public int Id { get; set; }
    public DateTime UserDate {get; set;}

    public string UsersSource{get;set;}

    public string Name {get;set;}

    public string Mobile{get;set;}
    public string Email {get;set;}

}
