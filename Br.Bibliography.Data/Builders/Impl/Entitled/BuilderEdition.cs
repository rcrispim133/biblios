using Br.Bibliography.Core.Constants.Impl.Entitled;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderEdition : 
        BuilderText<BuilderEdition, EntityEdition, IConstantEdition>, 
        IBuilderEdition<BuilderEdition>
    {
        public override IConstantEdition Constant { get; init; } = ConstantEdition.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityEdition>();

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

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextColumnName)
                .HasMaxLength(Constant.DefaultTextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Raltionships

            e.HasMany(x => x.EnumerableTitle)
                .WithOne(x => x.EntityEdition)
                .HasForeignKey(x => x.KeyEdition)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([StaticEntityNames.EDITION, StaticEntityNames.TITLE]));

            #endregion
        }
    }
}
