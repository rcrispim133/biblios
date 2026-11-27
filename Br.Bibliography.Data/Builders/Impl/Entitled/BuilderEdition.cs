using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;


namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderEdition : 
        BuilderText<BuilderEdition, EntityEdition>, 
        IBuilderEdition<BuilderEdition>
    {
        public override string[] EntityNameParts => [Constant.Base.EDITION];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityEdition>();

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

            e.HasMany(x => x.EnumerableTitle)
                .WithOne(x => x.EntityEdition)
                .HasForeignKey(x => x.KeyEdition)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.EDITION, Constant.Base.TITLE]));

            #endregion
        }
    }
}
