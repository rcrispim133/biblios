using Br.Bibliography.Core.Constants.Impl.Alumni;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Alumni
{
    public class BuilderType : BuilderText<BuilderType, EntityType, ConstantType>, IBuilderType<BuilderType>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityType>();

            // Table
            e.ToTable("tbl_type");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_type");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_type").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_type")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_type")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableLecture)
                .WithOne(x => x.EntityType)
                .HasForeignKey(x => x.KeyType)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_type_lecture");
        }
    }
}
