using Br.Bibliography.Core.Constants.Impl.Entitled;
using Br.Bibliography.Core.Constants.Interfaces.Entitled;
using Br.Bibliography.Core.Util.Static;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Entitled;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Entitled
{
    public class BuilderUrl : 
        BuilderText<BuilderUrl, EntityUrl, IConstantUrl>, 
        IBuilderUrl<BuilderUrl>
    {
        public override IConstantUrl Constant { get; init; } = ConstantUrl.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityUrl>();

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
                .HasColumnName(Constant.PropertyKeyName)
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.Text)
                .HasColumnName(Constant.PropertyTextName)
                .HasMaxLength(UrlMax)
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasMany(x => x.EnumerableTitleUrl)
                .WithOne(x => x.EntityUrl)
                .HasForeignKey(x => x.KeyUrl)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName(Constant.ForeignKeyName([StaticEntityNames.URL, StaticEntityNames.TITLE, StaticEntityNames.URL]));
        }
    }
}
