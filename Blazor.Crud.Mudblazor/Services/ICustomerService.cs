using Blazor.Crud.Mudblazor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Crud.Mudblazor.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomers();
        Task<Customer> GetCustomerById(int id);
        Task SaveCustomer(Customer customer);
        Task DeleteCustomer(int id);
    }
}
