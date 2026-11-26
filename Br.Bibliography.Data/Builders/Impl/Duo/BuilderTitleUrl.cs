using Br.Bibliography.Core.Constants.Impl.Duo;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderTitleUrl : 
        BuilderBase<BuilderTitleUrl, EntityTitleUrl, ConstantTitleUrl>, 
        IBuilderTitleUrl<BuilderTitleUrl>
    {
        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityTitleUrl>();

            // Table
            e.ToTable("tbl_title_url");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_title_url");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_title_url").IsUnique();
            
            e.HasIndex(x => x.KeyTitle).HasDatabaseName("idx_key_title_url_title").IsUnique(false);
            
            e.HasIndex(x => x.KeyUrl).HasDatabaseName("idx_key_title_url_url").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_title_url")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyTitle)
                .HasColumnName("key_title")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyUrl)
                .HasColumnName("key_url")
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityTitle)
                .WithMany(x => x.EnumerableTitleUrl)
                .HasForeignKey(x => x.KeyTitle)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_title_url_title");

            e.HasOne(x => x.EntityUrl)
                .WithMany(x => x.EnumerableTitleUrl)
                .HasForeignKey(x => x.KeyUrl)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_title_url_url");
        }
    }
}
