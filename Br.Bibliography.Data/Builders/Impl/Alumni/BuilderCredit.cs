using Br.Bibliography.Core.Constants.Impl.Alumni;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Alumni
{
    public class BuilderCredit : BuilderText<BuilderCredit, EntityCredit, ConstantCredit>, IBuilderCredit<BuilderCredit>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityCredit>();

            // Table
            e.ToTable("tbl_credit");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_credit");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_credit").IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_credit")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName("txt_credit")
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableLecture)
                .WithOne(x => x.EntityCredit)
                .HasForeignKey(x => x.KeyCredit)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_credit_lecture");
        }
    }
}
