
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Series;
using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Model.Entities.Impl.Series;
using Br.Bibliography.Util.Fluent.Base;

namespace Br.Bibliography.Data.Builders.Impl.Series
{
    public class BuilderCycle : 
        BuilderText<BuilderCycle, EntityCycle>, 
        IBuilderCycle<BuilderCycle>
    {
        public override string[] EntityNameParts => [Constant.Base.CYCLE];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityCycle>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts)).IsUnique();

            #endregion

            #region Order

            var order = Constant.Math.Zero;

            #endregion

            #region Properties

            e.Property(x => x.Key)
                .HasColumnName(Fluent.KeyColumnNameFromParams(EntityNameParts))
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Fluent.TextColumnNameFromParams(EntityNameParts))
                .HasMaxLength(Constant.Max.MaxText)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Raltionships

            e.HasMany(x => x.EnumerableCourse)
                .WithOne(x => x.EntityCycle)
                .HasForeignKey(x => x.KeyCycle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.CYCLE, Constant.Base.COURSE]));

            #endregion
        }
    }
}
