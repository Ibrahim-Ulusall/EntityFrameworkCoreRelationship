namespace EntityFrameworkProject.ManyToMany;

public class Book
{
    public int Id { get; set; }
    public string? BookName { get; set; }
    public ICollection<Author>? Authors { get; set; }
}
