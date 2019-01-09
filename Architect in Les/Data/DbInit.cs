using BusinessFacade;
using Data;
using System.Linq;

namespace Les190107.Data
{
    public class DbInit
    {
        public static void Initialize(CustomerContext context)
        {
            context.Database.EnsureCreated();

            //Zoek customers
            if (context.Customers.Any())
            {
                return;
            }

            context.Customers.AddRange(
                new Customer { Voornaam ="Tinny", Naam="Noyens"},
                new Customer { Voornaam ="Willem", Naam="Snoeckx"}
                );

            context.SaveChanges();
        }
    }
}
