using Br.Bibliography.Core.Constants.Impl.Entitled;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderPublisher : 
        BuilderText<BuilderPublisher, EntityPublisher, IConstantPublisher>, 
        IBuilderPublisher<BuilderPublisher>
    {
        public override IConstantPublisher Constant { get; init; } = ConstantPublisher.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityPublisher>();

            // Table
            e.ToTable("tbl_publisher");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_publisher");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_publisher").IsUnique();

            e.HasIndex(x => x.KeyCity).HasDatabaseName("idx_key_publisher_city").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_publisher")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_publisher")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityCity)
                .WithMany(x => x.EnumerablePublisher)
                .HasForeignKey(x => x.KeyCity)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_publisher_city");

            e.HasMany(x => x.EnumerableTitle)
                .WithOne(x => x.EntityPublisher)
                .HasForeignKey(x => x.KeyPublisher)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_publisher_title");
        }
    }
}
