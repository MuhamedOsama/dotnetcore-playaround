using Ensaf.Core.PostAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ensaf.Infrastructure.Data.Config
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.Property(p => p.Title)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(p => p.Body)
                .HasMaxLength(400)
                .IsRequired();
        }
    }
}
