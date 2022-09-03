namespace Core.Models;

public class Reservation : Base
{
    public int RoomId { get; set; }
    public Room Room { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public Payment Payment { get; set; }
    public ReservationFrom ReservationFrom  { get; set; }
    public int ReservationStatus { get; set; } // 1 = Confirmed | 0 = NotConfirmed
    public DateTime ReservationStrat { get; set; }
    public DateTime ReservationEnd { get; set; }
    public float PricePerNight { get; set; }
    public float TotalPrice { get; set; }
}

public enum Payment
{
    NotPaid,
    Cash,
    CreditCard
}

public enum ReservationFrom
{
    Booking,
    Google,
    Instagram,
    Facebook,
    Phone
}