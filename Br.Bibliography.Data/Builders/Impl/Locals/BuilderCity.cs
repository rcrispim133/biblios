using Br.Bibliography.Core.Constants.Impl.Locals;
using Br.Bibliography.Core.Constants.Interfaces.Locals;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Locals;
using Br.Bibliography.Model.Entities.Impl.Locals;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Locals
{
    public class BuilderCity : 
        BuilderText<BuilderCity, EntityCity, IConstantCity>, 
        IBuilderCity<BuilderCity>
    {
        public override IConstantCity Constant { get; init; } = ConstantCity.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityCity>();

            #endregion

            #region Table

            e.ToTable(Constant.TableName);

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.KeyState)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.CITY, StaticEntityNames.STATE]))
                .IsUnique(false);

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

            e.Property(x => x.KeyState)
                .HasColumnName(Constant.ForeignKeyColumnName([StaticEntityNames.STATE]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextColumnName)
                .HasMaxLength(Constant.DefaultTextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityState)
                .WithMany(x => x.EnumerableCity)
                .HasForeignKey(x => x.KeyState)
                .HasPrincipalKey(x=> x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.CITY, StaticEntityNames.STATE]));

            e.HasMany(x => x.EnumerablePublisher)
                .WithOne(x => x.EntityCity)
                .HasForeignKey(x => x.KeyCity)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.CITY, StaticEntityNames.PUBLISHER]));

            #endregion
        }
    }
}
