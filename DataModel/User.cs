using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class User: BaseProperties
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public UserTypeEnum Role { get; set; } = UserTypeEnum.CUSTOMER;
    }
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).IsRequired();

            builder.Property(t => t.UserName).HasMaxLength(50).IsRequired();
            builder.HasIndex(t => t.UserName).IsUnique();

            builder.Property(t => t.Password).HasMaxLength(100).IsRequired();
            builder.Property(t => t.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(t => t.LastName).HasMaxLength(50).IsRequired(false);
            builder.Property(t => t.Email).HasMaxLength(100).IsRequired();
            builder.HasIndex(t => t.Email).IsUnique();

            builder.Property(t => t.Role).IsRequired();


        }
    }
}
