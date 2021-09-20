using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BookStore.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder EntitiesOfType<T>(this ModelBuilder builder, Action<EntityTypeBuilder> action) where T : class
        {
            return builder.EntitiesOfType(typeof(T), action);
        }

        public static ModelBuilder EntitiesOfType(this ModelBuilder builder, Type type, Action<EntityTypeBuilder> action)
        {
            foreach(var entityType in builder.Model.GetEntityTypes())
            {
                if(type.IsAssignableFrom(entityType.ClrType))
                {
                    action(builder.Entity(entityType.ClrType));
                }
            }

            return builder;
        }
    }
}
