using assignment1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment1
{
    public class CustomerRepository
    {
        private readonly DataContext _context = DataContext.Instance;

        public List<Customers> GetAll()
        {
            return _context.Customer;
        }

        public Customers GetById(int id)
        {
            return _context.Customer.FirstOrDefault(c => c.CustomerID == id);
        }

        public List<Customers> SearchByName(string name)
        {
            return _context.Customer
                .Where(c => c.CompanyName.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public void Add(Customers customer)
        {
            customer.CustomerID = _context.Customer.Any()
                ? _context.Customer.Max(c => c.CustomerID) + 1
                : 1;
            _context.Customer.Add(customer);
        }

        public void Update(Customers customer)
        {
            var exist = GetById(customer.CustomerID);
            if (exist != null)
            {
                exist.CompanyName = customer.CompanyName;
                exist.ContactName = customer.ContactName;
                exist.ContactTitle = customer.ContactTitle;
                exist.Address = customer.Address;
                exist.Phone = customer.Phone;
            }
        }

        public void Delete(int id)
        {
            var customer = GetById(id);
            if (customer != null)
            {
                _context.Customer.Remove(customer);
            }
        }
    }
}
