using Br.Bibliography.Core.Constants.Impl.Locals;
using Br.Bibliography.Core.Constants.Impl.Sector;
using Br.Bibliography.Core.Constants.Interfaces.Locals;
using Br.Bibliography.Core.Constants.Interfaces.Sector;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Sector
{
    public class BuilderDetail : 
        BuilderText<BuilderDetail, EntityDetail, IConstantDetail>, 
        IBuilderDetail<BuilderDetail>
    {
        public override IConstantDetail Constant { get; init; } = ConstantDetail.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityDetail>();

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
                .HasMaxLength(Constant.ConstantMaxText)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableSection)
                .WithOne(x => x.EntityDetail)
                .HasForeignKey(x => x.KeyDetail)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.DETAIL, StaticEntityNames.SECTION]));
        }
    }
}
