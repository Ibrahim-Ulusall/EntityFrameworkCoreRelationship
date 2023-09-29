using EntityFrameworkProject.Context;

namespace EntityFrameworkProject.ManyToMany;
public class ManyToMany
{
    public static void AddEntityManyToMany()
    {
        using ApplicationDbContext context = new();
        Book book = new()
        {
            BookName = "A Kitabı",
            Authors = new HashSet<Author>() {
            new() { AuthorName = "A Yazar" },
            new() { AuthorName = "B Yazar" }
        }
        };
        context.Add(book);
        context.SaveChanges();
    }
}
