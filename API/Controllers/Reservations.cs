using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class Reservations : BaseApiController
{
    private readonly IGenericRepository<Reservation> _reservationRepo;
    public Reservations(IGenericRepository<Reservation> reservationRepo)
    {
        _reservationRepo = reservationRepo;
    }

    // GetReservations
    [HttpGet("get")]
    public async Task<ActionResult<Reservation>> GetReservations()
    {
        return Ok(await _reservationRepo.ListAllAsync());
    }

    // GetReservationById
    [HttpGet("get/{id}")]
    public async Task<ActionResult<Reservation>> GetReservationById(int id)
    {
        return Ok(await _reservationRepo.GetByIdAsync(id));
    }

    // AddReservation
    [HttpPost("add")]
    public async Task<ActionResult<Reservation>> AddReservation(Reservation res)
    {
        return Ok(await _reservationRepo.Add(res));
    }

    // UpdateReservation
    [HttpPut("update")]
    public async Task<ActionResult<Reservation>> UpdateReservation(Reservation res)
    {
        return Ok(await _reservationRepo.Update(res));
    }

    // DeleteReservation
    [HttpDelete("remove/{id}")]
    public async Task<ActionResult<Reservation>> RemoveReservation(int id)
    {
        return Ok(await _reservationRepo.Delete(id));
    }
}
