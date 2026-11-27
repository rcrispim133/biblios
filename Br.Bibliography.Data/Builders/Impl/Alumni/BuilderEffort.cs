using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Alumni
{
    public class BuilderEffort : BuilderText<BuilderEffort, EntityEffort>, IBuilderEffort<BuilderEffort>
    {
        public override string[] EntityNameParts => [Constant.Base.EFFORT];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityEffort>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Key

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

            #region Relationships

            e.HasMany(x => x.EnumerableLecture)
                .WithOne(x => x.EntityEffort)
                .HasForeignKey(x => x.KeyEffort)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.EFFORT, Constant.Base.LECTURE ]));

            #endregion
        }
    }
}
