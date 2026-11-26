using Br.Bibliography.Core.Constants.Impl.Biblio;
using Br.Bibliography.Core.Constants.Interfaces.Biblio;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Biblio;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Biblio
{
    public class BuilderAuthor : BuilderAcronym<BuilderAuthor, EntityAuthor, IConstantAuthor>, IBuilderAuthor<BuilderAuthor>
    {
        public override IConstantAuthor Constant { get; init; } = ConstantAuthor.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityAuthor>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyColumnName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Acronym)
                .HasColumnName("acronym_author")
                .HasMaxLength(Constant.PropertyAcronymMaxLength)
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextColumnName)
                .HasColumnOrder(order++)
                .HasMaxLength(Constant.PropertyTextMaxLength)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableBiblioAuthor)
                .WithOne(x => x.EntityAuthor)
                .HasForeignKey(x => x.KeyAuthor)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([ StaticEntityNames.AUTHOR, StaticEntityNames.BIBLIO, StaticEntityNames.AUTHOR ]));
        }
    }
}
