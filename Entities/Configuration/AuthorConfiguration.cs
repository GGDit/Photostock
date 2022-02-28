using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entities.Models;

namespace Entities.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData
            (
                new Author
                {
                    Id = Guid.NewGuid(),
                    Name = "IT_Solutions Ltd",
                    Nickname = "GGD",
                    AuthorCreationData = new DateTime(2022,2,2),
                    Age = 22,
                    Rating = 5
                }
            );
        }
    }
}
