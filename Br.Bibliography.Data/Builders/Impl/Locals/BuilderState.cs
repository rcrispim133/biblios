using Br.Bibliography.Core.Constants.Impl.Locals;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Locals
{
    public class BuilderState : 
        BuilderText<BuilderState, Model.Entities.Impl.Locals.EntityState, ConstantState>, 
        IBuilderState<BuilderState>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<Model.Entities.Impl.Locals.EntityState>();

            // Table
            e.ToTable("tbl_state");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_state");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_state").IsUnique();

            e.HasIndex(e => e.KeyCountry).HasDatabaseName("idx_key_state_country").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_state")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyCountry)
                .HasColumnName("key_country")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_state")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityCountry)
                .WithMany(x => x.EnumerableStates)
                .HasForeignKey(x => x.KeyCountry)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_state_country");

            e.HasMany(x => x.EnumerableCity)
                .WithOne(x => x.EntityState)
                .HasForeignKey(x => x.KeyState)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_state_city");
        }
    }
}
