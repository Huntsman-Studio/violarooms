using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
{
    public void Configure(EntityTypeBuilder<Reservation> builder)
    {
        builder.HasOne(c => c.Customer).WithMany(r => r.Reservations).HasForeignKey(c => c.CustomerId);
        builder.HasOne(r => r.Room).WithMany(r => r.Reservations).HasForeignKey(r => r.RoomId);
        builder.Property(r => r.ReservationFrom).IsRequired();
        builder.Property(r => r.ReservationStart).IsRequired();
        builder.Property(r => r.ReservationEnd).IsRequired();
        builder.Property(r => r.PricePerNight).IsRequired();
        builder.Property(r => r.TotalPrice).IsRequired();
    }
}
