using BookStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Data.FluentApiConfigurations
{
    public class PaperTypeConfiguration : IEntityTypeConfiguration<PaperType>
    {
        public void Configure(EntityTypeBuilder<PaperType> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired();
        }
    }
}
