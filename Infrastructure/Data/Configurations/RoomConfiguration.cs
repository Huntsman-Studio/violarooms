using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        builder.HasIndex(r => r.RoomName).IsUnique();
        builder.Property(r => r.RoomName).IsRequired();
        builder.Property(r => r.RoomSize).IsRequired();
        builder.HasMany(r => r.Reservations).WithOne(r => r.Room).HasForeignKey(r => r.RoomId);
    }
}
