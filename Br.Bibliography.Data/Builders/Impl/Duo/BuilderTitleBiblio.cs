using Br.Bibliography.Core.Constants.Impl.Duo;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderTitleBiblio : 
        BuilderBase<BuilderTitleBiblio, EntityTitleBiblio, IConstantTitleBiblio>, 
        IBuilderTitleBiblio<BuilderTitleBiblio>
    {
        public override IConstantTitleBiblio Constant { get; init; } = ConstantTitleBiblio.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityTitleBiblio>();

            // Table
            e.ToTable(Constant.TableName);

            // Key
            e.HasKey(x => x.Key).HasName(Constant.PrimaryKeyName);

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName(Constant.PrimaryKeyIndexName).IsUnique();
            
            e.HasIndex(x => x.KeyTitle).HasDatabaseName("idx_key_title_biblio_title").IsUnique(false);
            
            e.HasIndex(x => x.KeyBiblio).HasDatabaseName("idx_key_title_biblio_biblio").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName(Constant.PropertyKeyName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyTitle)
                .HasColumnName("key_title")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyBiblio)
                .HasColumnName("key_biblio")
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityTitle)
                .WithMany(x => x.EnumerableTitleBiblio)
                .HasForeignKey(x => x.KeyTitle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_title_biblio_title");

            e.HasOne(x => x.EntityBiblio)
                .WithMany(x => x.EnumerableTitleBiblio)
                .HasForeignKey(x => x.KeyBiblio)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_title_biblio_biblio");
        }
    }
}
