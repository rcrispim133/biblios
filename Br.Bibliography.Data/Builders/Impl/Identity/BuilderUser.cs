using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Identity
{
    public class BuilderUser : 
        BuilderBase<BuilderUser, EntityUser>, 
        IBuilderUser<BuilderUser>
    {
        public override string[] EntityNameParts => [Constant.Base.USER];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityUser>();

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
                    [Constant.Base.USER]))
                .IsUnique();

            e.HasIndex(x => x.Email).HasDatabaseName(
                Fluent.IndexDatabaseNameFromParams(
                    [Constant.Properties.EMAIL]))
                .IsUnique(true);

            e.HasIndex(x => x.UserName).HasDatabaseName(
                Fluent.IndexDatabaseNameFromParams(
                    [Constant.Properties.USERNAME]))
                .IsUnique(true);

            #endregion

            #region Order

            var order = Constant.Math.Zero;

            #endregion

            #region Properties

            e.Property(x => x.Id)
                .HasColumnName(Fluent.IdentityColumnNameFromParams([Constant.Base.USER]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Key)
                .HasColumnName(Fluent.KeyColumnNameFromParams(EntityNameParts))
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.UserName)
                .HasColumnName(Fluent.TextColumnNameFromParams([Constant.Properties.USERNAME]))
                .HasMaxLength(Constant.Max.MaxUsername)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Email)
                .HasColumnName(Fluent.TextColumnNameFromParams([Constant.Properties.EMAIL]))
                .HasMaxLength(Constant.Max.MaxEmail)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.EmailConfirmed)
                .HasColumnName(Fluent.LogicalColumnNameFromParams([Constant.Properties.EMAIL, Constant.Properties.CONFIRMED ]))
                .HasColumnOrder(order++)
                .IsRequired()
                .HasDefaultValue(false);

            e.Property(x => x.PasswordHash)
                .HasColumnName(Fluent.TextColumnNameFromParams([Constant.Properties.PASSWORD]))
                .HasMaxLength(Constant.Max.MaxPassword)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasMany(x => x.EnumerableUserClaim)
                .WithOne(x => x.EntityUser)
                .HasForeignKey(x => x.UserId)
                .HasPrincipalKey(x => x.Id)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.USER, Constant.Base.USER, Constant.Base.CLAIM ]));

            e.HasMany(x => x.EnumerableUserRole)
                .WithOne(x => x.EntityUser)
                .HasForeignKey(x => x.UserId)
                .HasPrincipalKey(x => x.Id)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.USER, Constant.Base.USER, Constant.Base.ROLE]));

            #endregion
        }
    }
}
