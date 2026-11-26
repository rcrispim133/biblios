using Br.Bibliography.Core.Constants.Impl.Duo;
using Br.Bibliography.Core.Constants.Interfaces.Duo;
using Br.Bibliography.Data.Builders.Base.Impl;
using Br.Bibliography.Data.Builders.Interfaces.Duo;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Microsoft.EntityFrameworkCore;

namespace Br.Bibliography.Data.Builders.Impl.Duo
{
    public class BuilderLecturePre : 
        BuilderBase<BuilderLecturePre, EntityLecturePre, IConstantLecturePre>, 
        IBuilderLecturePre<BuilderLecturePre>
    {
        public override IConstantLecturePre Constant { get; init; } = ConstantLecturePre.Factory();

        public override void Build(ModelBuilder builder)
        {
            var e = builder.Entity<EntityLecturePre>();

            // Table
            e.ToTable("tbl_lecture_pre");

            // Key
            e.HasKey(x => x.Key).HasName("pk_key_lecture_pre");

            // Index
            e.HasIndex(x => x.Key).HasDatabaseName("idx_key_lecture_pre").IsUnique();
            
            e.HasIndex(x => x.KeyLecture).HasDatabaseName("idx_key_lecture_pre_lecture").IsUnique(false);
            
            e.HasIndex(x => x.KeyPre).HasDatabaseName("idx_key_lecture_pre_pre").IsUnique(false);

            // Order
            var order = 0;

            // Properties
            e.Property(x => x.Key)
                .HasColumnName("key_lecture_pre")
                .HasColumnOrder(order++)
                .UseAutoincrement()
                .IsRequired();

            e.Property(x => x.KeyLecture)
                .HasColumnName("key_lecture")
                .HasColumnOrder(order++)
                .IsRequired();

            e.Property(x => x.KeyPre)
                .HasColumnName("key_pre")
                .HasColumnOrder(order++)
                .IsRequired();

            // Relationships
            e.HasOne(x => x.EntityLecture)
                .WithMany(x => x.EnumerableLecturePre)
                .HasForeignKey(x => x.KeyLecture)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_lecture_pre_lecture");

            e.HasOne(x => x.EntityPre)
                .WithMany(x => x.EnumerableLecturePre)
                .HasForeignKey(x => x.KeyPre)
                .HasPrincipalKey(x => x.Key)
                .HasConstraintName("fk_key_lecture_pre_pre");
        }
    }
}
