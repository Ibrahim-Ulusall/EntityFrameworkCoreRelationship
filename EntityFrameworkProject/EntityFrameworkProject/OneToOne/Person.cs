namespace EntityFrameworkProject.OneToOne;

public class Person
{
    public int Id { get; set; }
    public string? PersonName { get; set; }
    public Address? Address { get; set; }
}
