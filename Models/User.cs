public class User{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public Sex _Sex { get; set; }
    public DateOnly Date { get; set; }
    public string? UserName { get; set; }
    public string? Email { get; set; }
    //[Key]
    public string? Password { get; set; }
}

 public enum Sex{
        Male,
        Female,
        Object,
    }