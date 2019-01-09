using BusinessFacade;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public interface ICustomer
    {
        ICollection<Customer> GetAll();
        Customer GetById(int id);
        void Save(Customer customer);
    }


    public class CustomerData:ICustomer

    {
        CustomerContext context;
        public CustomerData(CustomerContext _context)
        {
            context = _context;
        }

        public ICollection<Customer> GetAll()
        {
            return context.Customers.ToList();

        }

        public Customer GetById (int id)
        {
            return context.Customers.Where(c => c.ID == id).Single();
        }

        public void Save (Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }


    }
}
