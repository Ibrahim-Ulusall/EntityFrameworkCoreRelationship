using EntityFrameworkProject.Context;

namespace EntityFrameworkProject.OneToMany;
public static class OneToMany
{
    public static void PrincipalEntityUzerindenDependentEntityVerisiEkleme()
    {
        ApplicationDbContext context = new();
        City city = new() { CityName = "Ankara", Districts = new HashSet<District>() { 
                new() { DistrictName = "Etimesgut" }, 
                new() { DistrictName = "Çankaya" } ,
                new() { DistrictName = "Kahramankazan" },
            } 
        };
        context.Add(city);
        context.SaveChanges();
    }


}
