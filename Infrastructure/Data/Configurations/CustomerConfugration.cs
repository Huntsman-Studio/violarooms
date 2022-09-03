using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class CustomerConfugration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasIndex(c => c.PhoneNumber).IsUnique();
        builder.HasIndex(c => c.Email).IsUnique();
        builder.HasMany(r => r.Reservations).WithOne(c => c.Customer).HasForeignKey(c => c.CustomerId);
    }
}
