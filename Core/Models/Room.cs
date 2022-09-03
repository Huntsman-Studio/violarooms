namespace Core.Models;

public class Room : Base
{
    public string RoomName { get; set; }
    public string RoomSize { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
}
