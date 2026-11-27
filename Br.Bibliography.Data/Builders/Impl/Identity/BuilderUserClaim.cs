using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Identity;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Identity
{
    public class BuilderUserClaim : 
        BuilderBase<BuilderUserClaim, EntityUserClaim>, 
        IBuilderUserClaim<BuilderUserClaim>
    {
        public override string[] EntityNameParts => [Constant.Base.USER, Constant.Base.CLAIM];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityUserClaim>();

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
                    [Constant.Base.USER, Constant.Base.CLAIM ]))
                .IsUnique();

            e.HasIndex(x => x.UserId)
                .HasDatabaseName(Fluent.IdentityDatabaseNameFromParams(
                    [Constant.Base.USER, Constant.Base.CLAIM, Constant.Base.USER ]))
                .IsUnique(false);

            #endregion

            #region Order

            var order = Constant.Math.Zero;

            #endregion

            #region Properties

            e.Property(x => x.Id)
                .HasColumnName(Fluent.IdentityColumnNameFromParams([Constant.Base.USER, Constant.Base.CLAIM]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Key)
                .HasColumnName(Fluent.KeyColumnNameFromParams(EntityNameParts))
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.UserId)
                .HasColumnName(Fluent.IdentityColumnNameFromParams([Constant.Base.USER]))
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.ClaimType)
                .HasColumnName(Fluent.TextColumnNameFromParams([Constant.Base.USER, Constant.Base.CLAIM, Constant.Base.TYPE]))
                .HasMaxLength(Constant.Max.MaxClaim)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.ClaimValue)
                .HasColumnName(Fluent.TextColumnNameFromParams([Constant.Base.USER, Constant.Base.CLAIM, Constant.Properties.VALUE ]))
                .HasMaxLength(Constant.Max.MaxClaim)
                .HasColumnOrder(order++)
                .IsRequired();

            #endregion

            #region Relationships

            e.HasOne(x => x.EntityUser)
                .WithMany(x => x.EnumerableUserClaim)
                .HasForeignKey(x => x.UserId)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([Constant.Base.USER, Constant.Base.CLAIM, Constant.Base.USER]));

            #endregion
        }
    }
}
