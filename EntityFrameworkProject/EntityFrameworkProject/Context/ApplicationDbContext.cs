using EntityFrameworkProject.ManyToMany;
using EntityFrameworkProject.OneToMany;
using EntityFrameworkProject.OneToOne;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkProject.Context;
public class ApplicationDbContext : DbContext
{
    public DbSet<Person> Persons { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Server=127.0.0.1; Port=5432; User Id=postgres; Password=toor; Database=TempDb");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>().HasOne(a => a.Person).WithOne(p => p.Address).HasForeignKey<Address>(a => a.Id);
        modelBuilder.Entity<City>().HasAlternateKey(n => n.CityName);
        modelBuilder.Entity<City>().HasMany(c => c.Districts).WithOne(d => d.City);
        
        modelBuilder.Entity<Author>().HasMany(w => w.Books).WithMany(b => b.Authors).UsingEntity("BookAuthor",
            l => l.HasOne(typeof(Book)).WithMany().HasForeignKey("BookId").HasPrincipalKey(nameof(Book.Id)),
            r => r.HasOne(typeof(Author)).WithMany().HasForeignKey("AuthorId").HasPrincipalKey(nameof(Author.Id)),
            j => j.HasKey("BookId", "AuthorId"));
    }
}