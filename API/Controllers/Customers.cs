using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class Customers : BaseApiController
{
    private readonly IGenericRepository<Customer> _customerRepo;
    public Customers(IGenericRepository<Customer> customerRepo)
    {
        _customerRepo = customerRepo;
    }

    // GetCustomers
    [HttpGet("get")]
    public async Task<ActionResult<Customer>> GetCustomers()
    {
        return Ok(await _customerRepo.ListAllAsync());
    }

    // GetCustomerById
    [HttpGet("get/{id}")]
    public async Task<ActionResult<Customer>> GetCustomerById(int id)
    {
        return Ok(await _customerRepo.GetByIdAsync(id));
    }
}
