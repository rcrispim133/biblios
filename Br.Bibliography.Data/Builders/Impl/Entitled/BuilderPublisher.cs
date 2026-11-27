using Br.Bibliography.Core.Constants.Impl.Entitled;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Core.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderPublisher : 
        BuilderText<BuilderPublisher, EntityPublisher, IConstantPublisher>, 
        IBuilderPublisher<BuilderPublisher>
    {
        public override IConstantPublisher Constant { get; init; } = ConstantPublisher.Factory();

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityPublisher>();

            #endregion

            #region Table

            e.ToTable(Constant.TableName);

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            e.HasIndex(x => x.KeyCity)
                .HasDatabaseName(Constant.IndexDatabaseName(
                    [StaticEntityNames.PUBLISHER, StaticEntityNames.CITY]))
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

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextColumnName)
                .HasMaxLength(Constant.DefaultTextMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityCity)
                .WithMany(x => x.EnumerablePublisher)
                .HasForeignKey(x => x.KeyCity)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.PUBLISHER, StaticEntityNames.CITY]));

            e.HasMany(x => x.EnumerableTitle)
                .WithOne(x => x.EntityPublisher)
                .HasForeignKey(x => x.KeyPublisher)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ConstraintName([StaticEntityNames.PUBLISHER, StaticEntityNames.TITLE]));

            #endregion
        }
    }
}
