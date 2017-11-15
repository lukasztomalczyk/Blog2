using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Context
{
    public class PostDbConfig : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(p => p.Id)
                   .HasColumnName("Post_id")
                   .HasColumnType("int")
                   .IsRequired();
            builder.Property(p => p.PostName)
                   .HasColumnName("Post_name")
                   .HasColumnType("varchar(50)")
                   .IsRequired();
            builder.Property(p => p.Text)
                   .HasColumnName("Content_Posts")
                   .HasColumnType("text")
                   .IsRequired();
            builder.Property(p => p.Category)
                   .HasColumnName("Category")
                   .HasColumnType("varchar(20)")
                   .IsRequired();
            builder.Property(p => p.DataTime)
                   .HasColumnName("Date")
                   .HasColumnType("datetime");
            builder.HasKey(k => k.Id);

            builder.HasOne(p => p.CurrentUser)
                   .WithMany(p => p.Posts)
                   .HasForeignKey(fk => fk.CurrentUserId);
        }
    }
}