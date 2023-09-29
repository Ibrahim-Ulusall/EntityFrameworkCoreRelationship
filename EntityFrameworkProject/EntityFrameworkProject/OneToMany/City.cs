namespace EntityFrameworkProject.OneToMany;

public class City
{
    public int Id { get; set; }
    public string? CityName { get; set; }
    public ICollection<District>? Districts { get; set; }
    public City()
    {
        Districts = new HashSet<District>();
    }
}
