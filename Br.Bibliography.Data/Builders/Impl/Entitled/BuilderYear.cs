
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Constants.Impl;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Util.Fluent.Base;


namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderYear : 
        BuilderBase<BuilderYear, EntityYear>, 
        IBuilderYear<BuilderYear>
    {
        public override string[] EntityNameParts => [Constant.Base.YEAR];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityYear>();

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
                .IsRequired();

            #endregion

            #region Relationships

            e.HasMany(x => x.EnumerableTitle)
                .WithOne(x => x.EntityYear)
                .HasForeignKey(x => x.KeyYear)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.YEAR, Constant.Base.TITLE]));

            #endregion
        }
    }
}
