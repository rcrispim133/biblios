using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;


namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderPublisher : 
        BuilderText<BuilderPublisher, EntityPublisher>, 
        IBuilderPublisher<BuilderPublisher>
    {
        public override string[] EntityNameParts => [Constant.Base.PUBLISHER];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityPublisher>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts)).IsUnique();

            e.HasIndex(x => x.KeyCity)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.PUBLISHER, Constant.Base.CITY]))
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

            e.Property(x => x.Text)
                .HasColumnName(Fluent.TextColumnNameFromParams(EntityNameParts))
                .HasMaxLength(Constant.Max.MaxText)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityCity)
                .WithMany(x => x.EnumerablePublisher)
                .HasForeignKey(x => x.KeyCity)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.PUBLISHER, Constant.Base.CITY]));

            e.HasMany(x => x.EnumerableTitle)
                .WithOne(x => x.EntityPublisher)
                .HasForeignKey(x => x.KeyPublisher)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.PUBLISHER, Constant.Base.TITLE]));

            #endregion
        }
    }
}
