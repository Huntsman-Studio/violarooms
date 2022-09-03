namespace Core.Models;

public class Customer : Base
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string IdNumber { get; set; }
    public string Country { get; set; }
    public Rating Rating { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
}

public enum Rating 
{
    VeryBad = 0,
    Bad = 25,
    Medium = 50,
    Good = 75,
    Excelent = 100
}