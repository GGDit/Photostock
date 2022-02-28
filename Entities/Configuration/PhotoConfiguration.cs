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
    public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            throw new NotImplementedException();
            //builder.HasData
            //(
                
            //    //new Photo
            //    //{
            //    //    Id = Guid.NewGuid(),
            //    //    Name = "Red cat",
                    
            //    //    Nickname = "GGD",
            //    //    AuthorCreationData = new DateTime(2022, 2, 2),
            //    //    Age = 22,
            //    //    Rating = 5
            //    //}
            //);
        }
    }
}
