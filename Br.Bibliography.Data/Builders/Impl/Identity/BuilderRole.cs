
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Identity;
using Microsoft.EntityFrameworkCore;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Util.Fluent.Base;


namespace Br.Bibliography.Data.Builders.Impl.Identity
{
    public class BuilderRole : 
        BuilderBase<BuilderRole, EntityRole>, 
        IBuilderRole<BuilderRole>
    {
        public override string[] EntityNameParts => [Constant.Base.ROLE];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityRole>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts)).IsUnique();

            e.HasIndex(x => x.Id)
                .HasDatabaseName(Fluent.IdentityDatabaseNameFromParams(
                    [Constant.Base.ROLE]))
                .IsUnique();

            e.HasIndex(x => x.Name).HasDatabaseName(
                Fluent.IndexDatabaseNameFromParams(
                    [ Constant.Base.ROLE, Constant.Properties.NAME ]))
                .IsUnique(true);

            #endregion

            #region Order

            var order = Constant.Math.Zero;

            #endregion

            #region Properties

            e.Property(x => x.Id)
                .HasColumnName(Fluent.IdentityColumnNameFromParams([Constant.Base.ROLE]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Key)
                .HasColumnName(Fluent.ForeignKeyColumnNameFromParams([Constant.Base.ROLE]))
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Name)
                .HasColumnName(Fluent.NameColumnNameFromParams([Constant.Base.ROLE]))
                .HasMaxLength(Constant.Max.MaxName)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasMany(x => x.EnumerableUserRole)
                .WithOne(x => x.EntityRole)
                .HasForeignKey(x => x.RoleId)
                .HasPrincipalKey(x => x.Id)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.USER, Constant.Base.ROLE, Constant.Base.ROLE]));

            #endregion
        }
    }
}