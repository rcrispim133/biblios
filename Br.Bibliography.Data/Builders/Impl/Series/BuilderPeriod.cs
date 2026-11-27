using Br.Bibliography.Core.Constants.Impl.Series;
using Br.Bibliography.Core.Constants.Interfaces.Series;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Series;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Series
{
    public class BuilderPeriod : 
        BuilderText<BuilderPeriod, EntityPeriod, IConstantPeriod>, 
        IBuilderPeriod<BuilderPeriod>
    {
        public override IConstantPeriod Constant { get; init; } = ConstantPeriod.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityPeriod>();

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

            #region Relatioinships

            e.HasMany(x => x.EnumerableCourse)
                .WithOne(x => x.EntityPeriod)
                .HasForeignKey(x => x.KeyPeriod)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyConstraintName([StaticEntityNames.PERIOD, StaticEntityNames.COURSE]));

            #endregion
        }
    }
}
