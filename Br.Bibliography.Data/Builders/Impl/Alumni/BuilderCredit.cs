using Br.Bibliography.Core.Constants.Impl.Alumni;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Alumni
{
    public class BuilderCredit : BuilderText<BuilderCredit, EntityCredit, IConstantCredit>, IBuilderCredit<BuilderCredit>
    {
        public override IConstantCredit Constant { get; init; } = ConstantCredit.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityCredit>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextName)
                .HasMaxLength(TextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableLecture)
                .WithOne(x => x.EntityCredit)
                .HasForeignKey(x => x.KeyCredit)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName(["credit", "lecture"]));
        }
    }
}
