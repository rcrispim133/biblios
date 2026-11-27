
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Sector;
using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Br.Bibliography.Util.Fluent.Base;

namespace Br.Bibliography.Data.Builders.Impl.Sector
{
    public class BuilderDetail : 
        BuilderText<BuilderDetail, EntityDetail>, 
        IBuilderDetail<BuilderDetail>
    {
        public override string[] EntityNameParts => [Constant.Base.DETAIL];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityDetail>();

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

            #region Detail

            e.HasMany(x => x.EnumerableSection)
                .WithOne(x => x.EntityDetail)
                .HasForeignKey(x => x.KeyDetail)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.DETAIL, Constant.Base.SECTION]));

            #endregion
        }
    }
}
