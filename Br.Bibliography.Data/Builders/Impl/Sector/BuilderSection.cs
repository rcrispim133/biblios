using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Sector;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;


namespace Br.Bibliography.Data.Builders.Impl.Sector
{
    public class BuilderSection : 
        BuilderBase<BuilderSection, EntitySection>, 
        IBuilderSection<BuilderSection>
    {
        public override string[] EntityNameParts => [Constant.Base.SECTION];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntitySection>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts)).IsUnique();

            e.HasIndex(x => x.KeyLecture)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.SECTION, Constant.Base.LECTURE]))
                .IsUnique(false);

            e.HasIndex(x => x.KeyDetail)
                .HasDatabaseName(Fluent.IndexDatabaseNameFromParams(
                    [Constant.Base.SECTION, Constant.Base.DETAIL]))
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

            e.Property(x => x.KeyLecture)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.LECTURE]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyDetail)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.DETAIL]))
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityLecture)
                .WithMany(x => x.EnumerableSection)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.SECTION, Constant.Base.LECTURE]));

            e.HasOne(x => x.EntityDetail)
                .WithMany(x => x.EnumerableSection)
                .HasForeignKey(x => x.KeyDetail)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.SECTION, Constant.Base.DETAIL]));

            e.HasMany(x => x.EnumerableLine)
                .WithOne(x => x.EntitySection)
                .HasForeignKey(x => x.KeySection)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.SECTION, Constant.Base.LINE]));

            #endregion
        }
    }
}
