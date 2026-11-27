
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Locals;
using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Model.Entities.Impl.Locals;
using Br.Bibliography.Util.Fluent.Base;

namespace Br.Bibliography.Data.Builders.Impl.Locals
{
    public class BuilderCity : 
        BuilderText<BuilderCity, EntityCity>, 
        IBuilderCity<BuilderCity>
    {
        public override string[] EntityNameParts => [Constant.Base.CITY];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityCity>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts)).IsUnique();

            e.HasIndex(x => x.KeyState)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.CITY, Constant.Base.STATE]))
                .IsUnique(false);

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

            e.Property(x => x.KeyState)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.STATE]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Fluent.TextColumnNameFromParams(EntityNameParts))
                .HasMaxLength(Constant.Max.MaxText)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityState)
                .WithMany(x => x.EnumerableCity)
                .HasForeignKey(x => x.KeyState)
                .HasPrincipalKey(x=> x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.CITY, Constant.Base.STATE]));

            e.HasMany(x => x.EnumerablePublisher)
                .WithOne(x => x.EntityCity)
                .HasForeignKey(x => x.KeyCity)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.CITY, Constant.Base.PUBLISHER]));

            #endregion
        }
    }
}
