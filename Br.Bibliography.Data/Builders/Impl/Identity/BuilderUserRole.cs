using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Identity
{
    public class BuilderUserRole :
        BuilderBase<BuilderUserRole, EntityUserRole>,
        IBuilderUserClaim<BuilderUserRole>
    {
        public override string[] EntityNameParts => [Constant.Base.USER, Constant.Base.ROLE];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityUserRole>();

            #endregion

            #region Table

            e.ToTable(Fluent.TableNameFromParams(EntityNameParts));

            #endregion

            #region Keys

            e.HasKey(x => x.Key).HasName(Fluent.PrimaryKeyConstraintFromParams(EntityNameParts));

            #endregion

            #region Index

            e.HasIndex(x => x.Key).HasDatabaseName(Fluent.PrimaryKeyIndexFromParams(EntityNameParts)).IsUnique();

            e.HasIndex(x => x.UserId)
                .HasDatabaseName(Fluent.IdentityDatabaseNameFromParams(
                    [Constant.Base.USER, Constant.Base.ROLE, Constant.Base.USER]))
                .IsUnique(false);

            e.HasIndex(x => x.RoleId)
                .HasDatabaseName(Fluent.IdentityDatabaseNameFromParams(
                    [Constant.Base.USER, Constant.Base.ROLE, Constant.Base.ROLE]))
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

            e.Property(x => x.UserId)
                .HasColumnName(Fluent.IdentityColumnNameFromParams([Constant.Base.USER]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.RoleId)
                .HasColumnName(Fluent.IdentityColumnNameFromParams([Constant.Base.ROLE]))
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityUser)
                .WithMany(x => x.EnumerableUserRole)
                .HasForeignKey(x => x.UserId)
                .HasPrincipalKey(x => x.Id)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.USER, Constant.Base.ROLE, Constant.Base.USER]));

            e.HasOne(x => x.EntityRole)
                .WithMany(x => x.EnumerableUserRole)
                .HasForeignKey(x => x.RoleId)
                .HasPrincipalKey(x => x.Id)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.USER, Constant.Base.ROLE, Constant.Base.ROLE]));

            #endregion
        }
    }
}
