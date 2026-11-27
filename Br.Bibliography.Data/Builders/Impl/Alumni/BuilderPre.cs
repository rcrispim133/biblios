using Br.Bibliography.Core.Constants.Impl.Alumni;
using Br.Bibliography.Core.Constants.Interfaces.Alumni;
using Br.Bibliography.Core.Static;
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
            #region Entity

            var e = builder.Entity<EntityPre>();

            #endregion

            #region Table

            e.ToTable(Constant.TableName);

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            #endregion

            #region Order

            var order = Constant.BaseOrder;

            #endregion

            #region Properties

            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyColumnName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            #endregion

            #region Relationships

            e.HasMany(x => x.EnumerableLecturePre)
                .WithOne(x => x.EntityPre)
                .HasForeignKey(x => x.KeyPre)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([ StaticEntityNames.PRE, StaticEntityNames.LECTURE, StaticEntityNames.PRE ]));

            #endregion
        }
    }
}
