namespace EntityFrameworkProject.OneToOne;

public class Address
{
    public int Id { get; set; }
    public string? Adress { get; set; }
    public Person? Person { get; set; }
}
