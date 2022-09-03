using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class Customers : BaseApiController
{
    // GetCustomers
    [HttpGet("get")]
    public async Task<ActionResult<Customer>> GetCustomers()
    {
        return Ok();
    }
}
