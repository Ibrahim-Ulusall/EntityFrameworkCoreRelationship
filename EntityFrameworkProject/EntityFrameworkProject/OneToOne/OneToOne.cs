using EntityFrameworkProject.Context;

namespace EntityFrameworkProject.OneToOne;

public static class OneToOne
{
    static ApplicationDbContext context = new();
    public static void AddPrincipalEntity()
    {
        //Pricipal Entity üzerinden ekleme işlemi yapılacaksa Dependent Entity oluşturmak zorunlud değildir.
        //Çünkü Principal Entity bağımlı değildir. Ancak Dependent Entity üzerinden ekleme yapılacaksa Princapal Entity
        //nesnesi oluşturmak zorunludur. Çünkü dependent entity princapal entity ile birebir ilişkisi vardır.
        Person person = new() { PersonName = "Vagrant", Address = new() { Adress = "Adana"} };
        context.Add(person);
        context.SaveChanges();
    }

    public static void AddDependentEntity()
    {
        Address address = new() { Adress = "Ankara", Person = new() { PersonName = "Root" } };
        context.Add(address);
        context.SaveChanges();
    }

}