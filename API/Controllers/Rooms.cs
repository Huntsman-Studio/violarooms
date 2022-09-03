using Core.Interfaces;
using Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class Rooms : BaseApiController
{
    private readonly IGenericRepository<Room> _roomsRepo;
    public Rooms(IGenericRepository<Room> roomsRepo)
    {
        _roomsRepo = roomsRepo;
    }

    // GetRooms
    [HttpGet("get")]
    public async Task<ActionResult<Room>> GetRooms()
    {
        return Ok(await _roomsRepo.ListAllAsync());
    }

    // GetRoomById
    [HttpGet("get/{id}")]
    public async Task<ActionResult<Room>> GetRoomById(int id)
    {
        return Ok(await _roomsRepo.GetByIdAsync(id));
    }

    // AddRoom
    [HttpPost("add")]
    public async Task<ActionResult<Room>> AddRoom(Room room)
    {
        return Ok(await _roomsRepo.Add(room));
    }

    // UpdateRoom
    [HttpPut("update")]
    public async Task<ActionResult<Room>> UpdateRoom(Room room)
    {
        return Ok(await _roomsRepo.Update(room));
    }

    // DeleteRooms
    [HttpDelete("delete/{id}")]
    public async Task<ActionResult<Room>> DeleteRoom(int id)
    {
        return Ok(await _roomsRepo.Delete(id));
    }
}
