using Br.Bibliography.Core.Constants.Impl.Alumni;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Alumni
{
    public class BuilderPre: BuilderBase<BuilderPre, EntityPre, ConstantPre>, IBuilderPre<BuilderPre>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityPre>();

            // Table
            e.ToTable("tbl_pre");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_pre");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_pre").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_pre")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableLecturePre)
                .WithOne(x => x.EntityPre)
                .HasForeignKey(x => x.KeyPre)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_pre_lecture");
        }
    }
}
