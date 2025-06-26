using assignment1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public  class CustomerService
    {
        private readonly CustomerRepository _customerRepository = new CustomerRepository();

        public List<Customers> GetAllCustomers() => _customerRepository.GetAll();

        public Customers GetCustomerById(int id) => _customerRepository.GetById(id);

        public List<Customers> SearchCustomers(string name) => _customerRepository.SearchByName(name);

        public bool AddCustomer(Customers customer)
        {
            if (string.IsNullOrWhiteSpace(customer.CompanyName) || string.IsNullOrWhiteSpace(customer.Phone))
                return false; // Validation
            _customerRepository.Add(customer);
            return true;
        }
}
}

public bool UpdateCustomer(Customer customer)
{
    if (string.IsNullOrWhiteSpace(customer.CompanyName) || string.IsNullOrWhiteSpace(customer.Phone))
        return false; // Validation
    _customerRepository.Update(customer);
    return true;
}

public bool DeleteCustomer(int id)
{
    var customer = _customerRepository.GetById(id);
    if (customer == null) return false;
    _customerRepository.Delete(id);
    return true;
}
    }
