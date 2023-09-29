namespace EntityFrameworkProject.OneToMany;

public class District
{
    public int Id { get; set; }
    public string? DistrictName { get; set; }
    public City? City { get; set; }
}
