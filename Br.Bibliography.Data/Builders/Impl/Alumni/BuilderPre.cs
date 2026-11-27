using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Alumni;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Util.Constants.Base;
using Br.Bibliography.Util.Constants.Impl;
using Br.Bibliography.Util.Fluent.Base;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Alumni
{
    public class BuilderPre: BuilderBase<BuilderPre, EntityPre>, IBuilderPre<BuilderPre>
    {
        public override string[] EntityNameParts => [ Constant.Base.PRE ];

        public override void Build(ModelBuilder builder)
        {
            #region Entity

            var e = builder.Entity<EntityPre>();

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

            #endregion

            #region Relationships

            e.HasMany(x => x.EnumerableLecturePre)
                .WithOne(x => x.EntityPre)
                .HasForeignKey(x => x.KeyPre)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Fluent.ForeignKeyConstraintNameFromParams([ Constant.Base.PRE, Constant.Base.LECTURE, Constant.Base.PRE ]));

            #endregion
        }
    }
}
