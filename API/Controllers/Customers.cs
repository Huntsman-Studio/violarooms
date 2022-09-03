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

    // AddCustomer
    [HttpPost("add")]
    public async Task<ActionResult<Customer>> AddCustomer(Customer customer)
    {
        return Ok(await _customerRepo.Add(customer));
    }

    // UpdateCustomer
    [HttpPut("update")]
    public async Task<ActionResult<Customer>> UpdateCustomer(Customer customer)
    {
        return Ok(await _customerRepo.Update(customer));
    }

    // DeleteCustomer
    [HttpDelete("delete/{id}")]
    public async Task<ActionResult<Customer>> DeleteCustomer(int id)
    {
        return Ok(await _customerRepo.Delete(id));
    }
}