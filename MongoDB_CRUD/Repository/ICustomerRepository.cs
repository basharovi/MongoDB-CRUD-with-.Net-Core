﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB_CRUD.Models;

namespace MongoDB_CRUD.Repository
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(string id);
        Task<Customer> CreateAsync(Customer customer);
        Task UpdateAsync(string id, Customer customer);
        Task<List<Customer>> DeleteAsync(string id);
    }
}
