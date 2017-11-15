using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Context
{
    public class UserDbConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.Id)
                   .HasColumnName("ID")
                   .HasColumnType("int");
            builder.HasKey(k => k.Id);
            builder.HasMany(k => k.Posts);
            builder.Property(p => p.FirstName)
                   .HasColumnName("First_Name")
                   .HasColumnType("varchar(20)");
        }
    }
}