using System.ComponentModel.DataAnnotations;

public class Login{
    public string UserName { get; set; }
    [Key]
    public string Password { get; set; }
}