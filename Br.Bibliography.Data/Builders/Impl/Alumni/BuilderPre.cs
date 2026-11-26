using Br.Bibliography.Core.Constants.Impl.Alumni;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Alumni
{
    public class BuilderPre: BuilderBase<BuilderPre, EntityPre, IConstantPre>, IBuilderPre<BuilderPre>
    {
        public override IConstantPre Constant { get; init; } = ConstantPre.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityPre>();

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

            // Relationships
            e.HasMany(x => x.EnumerableLecturePre)
                .WithOne(x => x.EntityPre)
                .HasForeignKey(x => x.KeyPre)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([ StaticEntityNames.PRE, StaticEntityNames.LECTURE, StaticEntityNames.PRE ]));
        }
    }
}
