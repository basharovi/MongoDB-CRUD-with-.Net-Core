using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB_CRUD.Models;

namespace MongoDB_CRUD.Services
{
    public class CustomerService : ICustomerService
    {

        public Task<List<Customer>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Customer> GetByIdAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Customer> CreateAsync(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(string id, Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Customer>> DeleteAsync(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
