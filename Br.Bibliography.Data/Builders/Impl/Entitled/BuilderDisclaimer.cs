using Br.Bibliography.Core.Constants.Impl.Entitled;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderDisclaimer : 
        BuilderDesc<BuilderDisclaimer, EntityDisclaimer, IConstantDisclaimer>, 
        IBuilderDisclaimer<BuilderDisclaimer>
    {
        public override IConstantDisclaimer Constant { get; init; } = ConstantDisclaimer.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityDisclaimer>();

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
                .HasColumnName(Constant.PropertyKeyColumnName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Desc)
                .HasColumnName("desc_disclaimer")
                .HasMaxLength(Constant.ConstantMaxDesc)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableTitle)
                .WithOne(x => x.EntityDisclaimer)
                .HasForeignKey(x => x.KeyDisclaimer)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.DISCLAIMER, StaticEntityNames.TITLE]));
        }
    }
}
