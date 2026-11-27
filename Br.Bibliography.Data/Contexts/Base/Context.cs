using Br.Bibliography.Data.Builders.Impl.Alumni;
using Br.Bibliography.Data.Builders.Impl.Biblio;
using Br.Bibliography.Data.Builders.Impl.Duo;
using Br.Bibliography.Data.Builders.Impl.Entitled;
using Br.Bibliography.Data.Builders.Impl.Identity;
using Br.Bibliography.Data.Builders.Impl.Locals;
using Br.Bibliography.Data.Builders.Impl.Sector;
using Br.Bibliography.Data.Builders.Impl.Series;
using Br.Bibliography.Data.Contexts.Base.Interfaces;
using Br.Bibliography.Data.Contexts.Interfaces.Alumni;
using Br.Bibliography.Data.Contexts.Interfaces.Biblio;
using Br.Bibliography.Data.Contexts.Interfaces.Duo;
using Br.Bibliography.Data.Contexts.Interfaces.Entitled;
using Br.Bibliography.Data.Contexts.Interfaces.Identity;
using Br.Bibliography.Data.Contexts.Interfaces.Locals;
using Br.Bibliography.Data.Contexts.Interfaces.Sector;
using Br.Bibliography.Data.Contexts.Interfaces.Series;
using Br.Bibliography.Model.Entities.Impl.Alumni;
using Br.Bibliography.Model.Entities.Impl.Biblio;
using Br.Bibliography.Model.Entities.Impl.Duo;
using Br.Bibliography.Model.Entities.Impl.Entitled;
using Br.Bibliography.Model.Entities.Impl.Identity;
using Br.Bibliography.Model.Entities.Impl.Locals;
using Br.Bibliography.Model.Entities.Impl.Sector;
using Br.Bibliography.Model.Entities.Impl.Series;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Br.Bibliography.Data.Contexts.Base
{
    public class Context : 
        IdentityDbContext<
            EntityUser, 
            EntityRole,
            int,
            EntityUserClaim, 
            IdentityUserRole<int>, 
            IdentityUserLogin<int>, 
            IdentityRoleClaim<int>, 
            IdentityUserToken<int>, 
            IdentityUserPasskey<int>>,
        IContext, 
        IContextCredit,
        IContextEffort,
        IContextLecture,
        IContextPre,
        IContextTeacher,
        IContextType,
        IContextWork,
        IContextAuthor,
        IContextBiblio,
        IContextImage,
        IContextBiblioAuthor,
        IContextBiblioImage,
        IContextBiblioLecture,
        IContextLectureCourse,
        IContextLecturePre,
        IContextLectureTeacher,
        IContextTitleBiblio,
        IContextTitleUrl,
        IContextDisclaimer,
        IContextEditon,
        IContextLanguage,
        IContextPublisher,
        IContextTitle,
        IContextUrl,
        IContextYear,
        IContextUser,
        IContextRole,
        IContextUserClaim,
        IContextCity,
        IContextCountry,
        IContextState,
        IContextDetail,
        IContextLine,
        IContextSection,
        IContextCourse,
        IContextCycle,
        IContextDuration,
        IContextPeriod,
        IContextUnit
    {

        #region CONSTRUCTORS

        public Context(DbContextOptions<Context> options) : base(options) { }

        public Context() : base() { }

        #endregion

        #region Alumni

        #region Credit

        public DbSet<EntityCredit> DbSetCredit { get; set; }

        DbSet<EntityCredit> IContextBase<EntityCredit>.DbSet => DbSetCredit;

        #endregion

        #region Effort

        public DbSet<EntityEffort> DbSetEffort { get; set; }

        DbSet<EntityEffort> IContextBase<EntityEffort>.DbSet => DbSetEffort;

        #endregion

        #region Lecture

        public DbSet<EntityLecture> DbSetLecture { get; set; }

        DbSet<EntityLecture> IContextBase<EntityLecture>.DbSet => DbSetLecture;

        #endregion

        #region Pre

        public DbSet<EntityPre> DbSetPre { get; set; }

        DbSet<EntityPre> IContextBase<EntityPre>.DbSet => DbSetPre;


        #endregion

        #region Teacher

        public DbSet<EntityTeacher> DbSetTeacher { get; set; }

        DbSet<EntityTeacher> IContextBase<EntityTeacher>.DbSet => DbSetTeacher;

        #endregion

        #region Type

        public DbSet<EntityType> DbSetType { get; set; }

        DbSet<EntityType> IContextBase<EntityType>.DbSet => DbSetType;


        #endregion

        #region Work

        public DbSet<EntityWork> DbSetWork { get; set; }

        DbSet<EntityWork> IContextBase<EntityWork>.DbSet => DbSetWork;

        #endregion

        #endregion

        #region Biblio

        #region Author

        public DbSet<EntityAuthor> DbSetAuthor { get; set; }

        DbSet<EntityAuthor> IContextBase<EntityAuthor>.DbSet => DbSetAuthor;

        #endregion

        #region Biblio

        public DbSet<EntityBiblio> DbSetBiblio { get; set; }

        DbSet<EntityBiblio> IContextBase<EntityBiblio>.DbSet => DbSetBiblio;

        #endregion

        #region Image

        public DbSet<EntityImage> DbSetImage { get; set; }

        DbSet<EntityImage> IContextBase<EntityImage>.DbSet => DbSetImage;

        #endregion

        #endregion

        #region Duo

        #region BiblioAuthor

        public DbSet<EntityBiblioAuthor> DbSetBiblioAuthor { get; set; }

        DbSet<EntityBiblioAuthor> IContextBase<EntityBiblioAuthor>.DbSet => DbSetBiblioAuthor;

        #endregion

        #region BiblioImage

        public DbSet<EntityBiblioImage> DbSetBiblioImage { get; set; }

        DbSet<EntityBiblioImage> IContextBase<EntityBiblioImage>.DbSet => DbSetBiblioImage;

        #endregion

        #region BiblioLecture

        public DbSet<EntityBiblioLecture> DbSetBiblioLecture { get; set; }

        DbSet<EntityBiblioLecture> IContextBase<EntityBiblioLecture>.DbSet => DbSetBiblioLecture;

        #endregion

        #region LectureCourse

        public DbSet<EntityLectureCourse> DbSetLectureCourse { get; set; }

        DbSet<EntityLectureCourse> IContextBase<EntityLectureCourse>.DbSet => DbSetLectureCourse;

        #endregion

        #region LecturePre

        public DbSet<EntityLecturePre> DbSetLecturePre { get; set; }

        DbSet<EntityLecturePre> IContextBase<EntityLecturePre>.DbSet => DbSetLecturePre;

        #endregion

        #region LectureTeacher

        public DbSet<EntityLectureTeacher> DbSetLectureTeacher { get; set; }

        DbSet<EntityLectureTeacher> IContextBase<EntityLectureTeacher>.DbSet => DbSetLectureTeacher;

        #endregion

        #region TitleBiblio

        public DbSet<EntityTitleBiblio> DbSetTitleBiblio { get; set; }

        DbSet<EntityTitleBiblio> IContextBase<EntityTitleBiblio>.DbSet => DbSetTitleBiblio;

        #endregion

        #region TitleUrl

        public DbSet<EntityTitleUrl> DbSetTitleUrl { get; set; }

        DbSet<EntityTitleUrl> IContextBase<EntityTitleUrl>.DbSet => DbSetTitleUrl;

        #endregion

        #endregion

        #region Entitled

        #region Disclaimer

        public DbSet<EntityDisclaimer> DbSetDisclaimer { get; set; }

        DbSet<EntityDisclaimer> IContextBase<EntityDisclaimer>.DbSet => DbSetDisclaimer;

        #endregion

        #region Edition

        public DbSet<EntityEdition> DbSetEdition { get; set; }

        DbSet<EntityEdition> IContextBase<EntityEdition>.DbSet => DbSetEdition;

        #endregion

        #region Language

        public DbSet<EntityLanguage> DbSetLanguage { get; set; }

        DbSet<EntityLanguage> IContextBase<EntityLanguage>.DbSet => DbSetLanguage;

        #endregion

        #region Publisher

        public DbSet<EntityPublisher> DbSetPublisher { get; set; }

        DbSet<EntityPublisher> IContextBase<EntityPublisher>.DbSet => DbSetPublisher;

        #endregion

        #region Title

        public DbSet<EntityTitle> DbSetTitle { get; set; }

        DbSet<EntityTitle> IContextBase<EntityTitle>.DbSet => DbSetTitle;

        #endregion

        #region Url

        public DbSet<EntityUrl> DbSetUrl { get; set; }

        DbSet<EntityUrl> IContextBase<EntityUrl>.DbSet => DbSetUrl;

        #endregion

        #region Year

        public DbSet<EntityYear> DbSetYear { get; set; }

        DbSet<EntityYear> IContextBase<EntityYear>.DbSet => DbSetYear;

        #endregion

        #endregion

        #region Identity

        #region Role

        [JsonIgnore]
        [NotMapped]
        public override DbSet<EntityRole> Roles { get; set; }

        public DbSet<EntityRole> DbSetRow => Roles;

        DbSet<EntityRole> IContextBase<EntityRole>.DbSet => DbSetRow;

        #endregion

        #region User

        [JsonIgnore]
        [NotMapped]
        public override DbSet<EntityUser> Users { get; set; }

        public DbSet<EntityUser> DbSetUser => Users;

        DbSet<EntityUser> IContextBase<EntityUser>.DbSet => DbSetUser;

        #endregion

        #region User Claim

        [JsonIgnore]
        [NotMapped]
        public override DbSet<EntityUserClaim> UserClaims { get; set; }

        public DbSet<EntityUserClaim> DbSetUserClaim => UserClaims;

        DbSet<EntityUserClaim> IContextBase<EntityUserClaim>.DbSet => DbSetUserClaim;

        #endregion

        #endregion

        #region Locals

        #region City

        public DbSet<EntityCity> DbSetCity { get; set; }

        DbSet<EntityCity> IContextBase<EntityCity>.DbSet => DbSetCity;

        #endregion

        #region Country

        public DbSet<EntityCountry> DbSetCountry { get; set; }

        DbSet<EntityCountry> IContextBase<EntityCountry>.DbSet => DbSetCountry;

        #endregion

        #region State

        public DbSet<Model.Entities.Impl.Locals.EntityState> DbSetState { get; set; }

        DbSet<Model.Entities.Impl.Locals.EntityState> IContextBase<Model.Entities.Impl.Locals.EntityState>.DbSet => DbSetState;

        #endregion

        #endregion

        #region Sector

        #region Detail

        public DbSet<EntityDetail> DbSetDetail { get; set; }

        DbSet<EntityDetail> IContextBase<EntityDetail>.DbSet => DbSetDetail;

        #endregion

        #region Line

        public DbSet<EntityLine> DbSetLine { get; set; }

        DbSet<EntityLine> IContextBase<EntityLine>.DbSet => DbSetLine;

        #endregion

        #region Section

        public DbSet<EntitySection> DbSetSection { get; set; }

        DbSet<EntitySection> IContextBase<EntitySection>.DbSet => DbSetSection;

        #endregion

        #endregion

        #region Series

        #region Course

        public DbSet<EntityCourse> DbSetCourse { get; set; }

        DbSet<EntityCourse> IContextBase<EntityCourse>.DbSet => DbSetCourse;

        #endregion

        #region Cycle

        public DbSet<EntityCycle> DbSetCycle { get; set; }

        DbSet<EntityCycle> IContextBase<EntityCycle>.DbSet => DbSetCycle;

        #endregion

        #region Duration

        public DbSet<EntityDuration> DbSetDuration { get; set; }

        DbSet<EntityDuration> IContextBase<EntityDuration>.DbSet => DbSetDuration;

        #endregion

        #region Period

        public DbSet<EntityPeriod> DbSetPeriod { get; set; }

        DbSet<EntityPeriod> IContextBase<EntityPeriod>.DbSet => DbSetPeriod;

        #endregion

        #region Unit

        public DbSet<EntityUnit> DbSetUnit { get; set; }

        DbSet<EntityUnit> IContextBase<EntityUnit>.DbSet => DbSetUnit;

        #endregion

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string basePath = Path.GetFullPath("../Br.Bibliography.Data");
            string backupPath = $"{basePath}/Backups";
            if (!Directory.Exists(backupPath)) Directory.CreateDirectory(backupPath);

            string filePath = $"{basePath}/database.db";
            string fileBackup = $"{backupPath}/database-{DateTime.Now:yyyyMMddhhmmss}.db";
            if (File.Exists(filePath)) File.Copy(filePath, fileBackup, true);

            string connectionString = $"Data Source={filePath}";
            optionsBuilder.UseSqlite(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Alumni

            BuilderCredit.Singleton.Build(builder);
            BuilderEffort.Singleton.Build(builder);
            BuilderLecture.Singleton.Build(builder);
            BuilderPre.Singleton.Build(builder);
            BuilderTeacher.Singleton.Build(builder);
            BuilderType.Singleton.Build(builder);
            BuilderWork.Singleton.Build(builder);

            #endregion

            #region Biblio

            BuilderAuthor.Singleton.Build(builder);
            BuilderBiblio.Singleton.Build(builder);
            BuilderImage.Singleton.Build(builder);

            #endregion

            #region Duo

            BuilderBiblioAuthor.Singleton.Build(builder);
            BuilderBiblioImage.Singleton.Build(builder);
            BuilderBiblioLecture.Singleton.Build(builder);
            BuilderLectureCourse.Singleton.Build(builder);
            BuilderLecturePre.Singleton.Build(builder);
            BuilderLectureTeacher.Singleton.Build(builder);
            BuilderTitleBiblio.Singleton.Build(builder);
            BuilderTitleUrl.Singleton.Build(builder);


            #endregion

            #region Entitled

            BuilderDisclaimer.Singleton.Build(builder);
            BuilderEdition.Singleton.Build(builder);
            BuilderLanguage.Singleton.Build(builder);
            BuilderPublisher.Singleton.Build(builder);
            BuilderTitle.Singleton.Build(builder);
            BuilderUrl.Singleton.Build(builder);
            BuilderYear.Singleton.Build(builder);

            #endregion

            #region Identity

            BuilderRole.Singleton.Build(builder);

            BuilderUser.Singleton.Build(builder);

            BuilderUserClaim.Singleton.Build(builder);

            #endregion

            #region Locals

            BuilderCity.Singleton.Build(builder);
            BuilderCountry.Singleton.Build(builder);
            BuilderState.Singleton.Build(builder);


            #endregion

            #region Sector

            BuilderDetail.Singleton.Build(builder);
            BuilderLine.Singleton.Build(builder);
            BuilderSection.Singleton.Build(builder);

            #endregion

            #region Series

            BuilderCourse.Singleton.Build(builder);
            BuilderCycle.Singleton.Build(builder);
            BuilderDuration.Singleton.Build(builder);
            BuilderPeriod.Singleton.Build(builder);
            BuilderUnit.Singleton.Build(builder);

            #endregion
        }
    }
}
