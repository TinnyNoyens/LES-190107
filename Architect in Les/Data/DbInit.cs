using Les190107.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
