using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Br.Bibliography.Data.Migrations;

/// <inheritdoc />
public partial class _20261124160108_Util : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.CreateTable(
            name: "tbl_author",
            columns: table => new
            {
                key_author = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                acronym_author = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                txt_author = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_author", x => x.key_author);
            });

        migrationBuilder.CreateTable(
            name: "tbl_biblio",
            columns: table => new
            {
                key_biblio = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_biblio", x => x.key_biblio);
            });

        migrationBuilder.CreateTable(
            name: "tbl_country",
            columns: table => new
            {
                key_country = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_country = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_country", x => x.key_country);
            });

        migrationBuilder.CreateTable(
            name: "tbl_credit",
            columns: table => new
            {
                key_credit = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_credit = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_credit", x => x.key_credit);
            });

        migrationBuilder.CreateTable(
            name: "tbl_cycle",
            columns: table => new
            {
                key_cycle = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_cycle = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_cycle", x => x.key_cycle);
            });

        migrationBuilder.CreateTable(
            name: "tbl_detail",
            columns: table => new
            {
                key_detail = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_detail = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_detail", x => x.key_detail);
            });

        migrationBuilder.CreateTable(
            name: "tbl_disclaimer",
            columns: table => new
            {
                key_disclaimer = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                desc_disclaimer = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_disclaimer", x => x.key_disclaimer);
            });

        migrationBuilder.CreateTable(
            name: "tbl_duration",
            columns: table => new
            {
                key_duration = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_duration = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_duration", x => x.key_duration);
            });

        migrationBuilder.CreateTable(
            name: "tbl_edition",
            columns: table => new
            {
                key_edition = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_edition = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_edition", x => x.key_edition);
            });

        migrationBuilder.CreateTable(
            name: "tbl_effort",
            columns: table => new
            {
                key_effort = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_effort = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_effort", x => x.key_effort);
            });

        migrationBuilder.CreateTable(
            name: "tbl_image",
            columns: table => new
            {
                key_image = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_image = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false),
                raw_image = table.Column<byte[]>(type: "BLOB", maxLength: 16384, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_image", x => x.key_image);
            });

        migrationBuilder.CreateTable(
            name: "tbl_language",
            columns: table => new
            {
                key_language = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_language = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_language", x => x.key_language);
            });

        migrationBuilder.CreateTable(
            name: "tbl_period",
            columns: table => new
            {
                key_period = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_period = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_period", x => x.key_period);
            });

        migrationBuilder.CreateTable(
            name: "tbl_pre",
            columns: table => new
            {
                key_pre = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_pre", x => x.key_pre);
            });

        migrationBuilder.CreateTable(
            name: "tbl_role",
            columns: table => new
            {
                id_role = table.Column<int?>(type: "INTEGER", nullable: false),
                key_role = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                name_role = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_role", x => x.key_role);
            });

        migrationBuilder.CreateTable(
            name: "tbl_teacher",
            columns: table => new
            {
                key_teacher = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_teacher = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_teacher", x => x.key_teacher);
            });

        migrationBuilder.CreateTable(
            name: "tbl_type",
            columns: table => new
            {
                key_type = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_type = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_type", x => x.key_type);
            });

        migrationBuilder.CreateTable(
            name: "tbl_unit",
            columns: table => new
            {
                key_unit = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                acronym_unit = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                txt_unit = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_unit", x => x.key_unit);
            });

        migrationBuilder.CreateTable(
            name: "tbl_url",
            columns: table => new
            {
                key_url = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_url = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_url", x => x.key_url);
            });

        migrationBuilder.CreateTable(
            name: "tbl_user",
            columns: table => new
            {
                id_user = table.Column<int?>(type: "INTEGER", nullable: false),
                key_user = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                username_user = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                email_user = table.Column<string>(type: "TEXT", maxLength: 96, nullable: false),
                email_confirmed_user = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                pwd_user = table.Column<string>(type: "TEXT", maxLength: 1024, nullable: false),
                NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_user", x => x.key_user);
                table.UniqueConstraint("AK_tbl_user_id_user", x => x.id_user);
            });

        migrationBuilder.CreateTable(
            name: "tbl_work",
            columns: table => new
            {
                key_work = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_work = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_work", x => x.key_work);
            });

        migrationBuilder.CreateTable(
            name: "tbl_year",
            columns: table => new
            {
                key_year = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_year", x => x.key_year);
            });

        migrationBuilder.CreateTable(
            name: "tbl_biblio_author",
            columns: table => new
            {
                key_biblio_author = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                key_biblio = table.Column<int?>(type: "INTEGER", nullable: false),
                key_author = table.Column<int?>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_biblio_author", x => x.key_biblio_author);
                table.ForeignKey(
                    name: "fk_key_biblio_author_author",
                    column: x => x.key_author,
                    principalTable: "tbl_author",
                    principalColumn: "key_author",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_key_biblio_author_biblio",
                    column: x => x.key_biblio,
                    principalTable: "tbl_biblio",
                    principalColumn: "key_biblio",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_state",
            columns: table => new
            {
                key_state = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                key_country = table.Column<int?>(type: "INTEGER", nullable: false),
                txt_state = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_state", x => x.key_state);
                table.ForeignKey(
                    name: "fk_state_country",
                    column: x => x.key_country,
                    principalTable: "tbl_country",
                    principalColumn: "key_country",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_biblio_image",
            columns: table => new
            {
                key_biblio_image = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                key_biblio = table.Column<int?>(type: "INTEGER", nullable: false),
                key_image = table.Column<int?>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_biblio_image", x => x.key_biblio_image);
                table.ForeignKey(
                    name: "fk_key_biblio_image_biblio",
                    column: x => x.key_biblio,
                    principalTable: "tbl_biblio",
                    principalColumn: "key_biblio",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_key_biblio_image_image",
                    column: x => x.key_biblio,
                    principalTable: "tbl_image",
                    principalColumn: "key_image",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetRoleClaims",
            columns: table => new
            {
                Id = table.Column<int>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                RoleId = table.Column<int?>(type: "INTEGER", nullable: false),
                ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                table.ForeignKey(
                    name: "FK_AspNetRoleClaims_tbl_role_RoleId",
                    column: x => x.RoleId,
                    principalTable: "tbl_role",
                    principalColumn: "key_role",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_course",
            columns: table => new
            {
                key_course = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                key_unit = table.Column<int?>(type: "INTEGER", nullable: false),
                key_period = table.Column<int?>(type: "INTEGER", nullable: false),
                key_cycle = table.Column<int?>(type: "INTEGER", nullable: false),
                key_duration = table.Column<int?>(type: "INTEGER", nullable: false),
                Text = table.Column<string>(type: "TEXT", nullable: true),
                Acronym = table.Column<string>(type: "TEXT", nullable: true),
                Desc = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_course", x => x.key_course);
                table.ForeignKey(
                    name: "fk_cycle_course",
                    column: x => x.key_cycle,
                    principalTable: "tbl_cycle",
                    principalColumn: "key_cycle",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_duration_course",
                    column: x => x.key_duration,
                    principalTable: "tbl_duration",
                    principalColumn: "key_duration",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_period_course",
                    column: x => x.key_period,
                    principalTable: "tbl_period",
                    principalColumn: "key_period",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_unit_course",
                    column: x => x.key_unit,
                    principalTable: "tbl_unit",
                    principalColumn: "key_unit",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserLogins",
            columns: table => new
            {
                LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                UserId = table.Column<int?>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                table.ForeignKey(
                    name: "FK_AspNetUserLogins_tbl_user_UserId",
                    column: x => x.UserId,
                    principalTable: "tbl_user",
                    principalColumn: "key_user",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserRoles",
            columns: table => new
            {
                UserId = table.Column<int?>(type: "INTEGER", nullable: false),
                RoleId = table.Column<int?>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                table.ForeignKey(
                    name: "FK_AspNetUserRoles_tbl_role_RoleId",
                    column: x => x.RoleId,
                    principalTable: "tbl_role",
                    principalColumn: "key_role",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "FK_AspNetUserRoles_tbl_user_UserId",
                    column: x => x.UserId,
                    principalTable: "tbl_user",
                    principalColumn: "key_user",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "AspNetUserTokens",
            columns: table => new
            {
                UserId = table.Column<int?>(type: "INTEGER", nullable: false),
                LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                Name = table.Column<string>(type: "TEXT", nullable: false),
                Value = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                table.ForeignKey(
                    name: "FK_AspNetUserTokens_tbl_user_UserId",
                    column: x => x.UserId,
                    principalTable: "tbl_user",
                    principalColumn: "key_user",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_user_claim",
            columns: table => new
            {
                id_user_claim = table.Column<int>(type: "INTEGER", nullable: false),
                key_user_claim = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                id_user = table.Column<int?>(type: "INTEGER", nullable: false),
                txt_claim_type = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                txt_claim_value = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_user_claim", x => x.key_user_claim);
                table.ForeignKey(
                    name: "fk_user_claim_user",
                    column: x => x.id_user,
                    principalTable: "tbl_user",
                    principalColumn: "key_user",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_lecture",
            columns: table => new
            {
                key_lecture = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                key_credit = table.Column<int?>(type: "INTEGER", nullable: false),
                key_work = table.Column<int?>(type: "INTEGER", nullable: false),
                key_effort = table.Column<int?>(type: "INTEGER", nullable: false),
                key_type = table.Column<int?>(type: "INTEGER", nullable: false),
                acronym_lecture = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                txt_lecture = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false),
                trans_lecture = table.Column<string>(type: "TEXT", maxLength: 144, nullable: true),
                dt_act_lecture = table.Column<DateTime>(type: "TEXT", nullable: true),
                dt_deact_lecture = table.Column<DateTime>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_lecture", x => x.key_lecture);
                table.ForeignKey(
                    name: "fk_lecture_credit",
                    column: x => x.key_credit,
                    principalTable: "tbl_credit",
                    principalColumn: "key_credit",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_lecture_effort",
                    column: x => x.key_effort,
                    principalTable: "tbl_effort",
                    principalColumn: "key_effort",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_type_lecture",
                    column: x => x.key_type,
                    principalTable: "tbl_type",
                    principalColumn: "key_type",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_work_lecture",
                    column: x => x.key_work,
                    principalTable: "tbl_work",
                    principalColumn: "key_work",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_city",
            columns: table => new
            {
                key_city = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                key_state = table.Column<int?>(type: "INTEGER", nullable: false),
                txt_city = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_city", x => x.key_city);
                table.ForeignKey(
                    name: "fk_state_city",
                    column: x => x.key_state,
                    principalTable: "tbl_state",
                    principalColumn: "key_state",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_biblio_lecture",
            columns: table => new
            {
                key_biblio_lecture = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                key_biblio = table.Column<int?>(type: "INTEGER", nullable: false),
                key_lecture = table.Column<int?>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_biblio_lecture", x => x.key_biblio_lecture);
                table.ForeignKey(
                    name: "fk_key_biblio_lecture_biblio",
                    column: x => x.key_biblio,
                    principalTable: "tbl_biblio",
                    principalColumn: "key_biblio",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_key_biblio_lecture_lecture",
                    column: x => x.key_lecture,
                    principalTable: "tbl_lecture",
                    principalColumn: "key_lecture",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_lecture_course",
            columns: table => new
            {
                key_lecture_course = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                key_lecture = table.Column<int?>(type: "INTEGER", nullable: false),
                key_course = table.Column<int?>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_lecture_course", x => x.key_lecture_course);
                table.ForeignKey(
                    name: "fk_course_line",
                    column: x => x.key_course,
                    principalTable: "tbl_course",
                    principalColumn: "key_course",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_key_lecture_course_lecture",
                    column: x => x.key_lecture,
                    principalTable: "tbl_lecture",
                    principalColumn: "key_lecture",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_lecture_pre",
            columns: table => new
            {
                key_lecture_pre = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                key_lecture = table.Column<int?>(type: "INTEGER", nullable: false),
                key_pre = table.Column<int?>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_lecture_pre", x => x.key_lecture_pre);
                table.ForeignKey(
                    name: "fk_key_lecture_pre_lecture",
                    column: x => x.key_lecture,
                    principalTable: "tbl_lecture",
                    principalColumn: "key_lecture",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_key_lecture_pre_pre",
                    column: x => x.key_pre,
                    principalTable: "tbl_pre",
                    principalColumn: "key_pre",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_lecture_teacher",
            columns: table => new
            {
                key_lecture_teacher = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                key_lecture = table.Column<int?>(type: "INTEGER", nullable: false),
                key_teacher = table.Column<int?>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_lecture_teacher", x => x.key_lecture_teacher);
                table.ForeignKey(
                    name: "fk_key_lecture_teacher_lecture",
                    column: x => x.key_lecture,
                    principalTable: "tbl_lecture",
                    principalColumn: "key_lecture",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_key_lecture_teacher_teacher",
                    column: x => x.key_teacher,
                    principalTable: "tbl_teacher",
                    principalColumn: "key_teacher",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_section",
            columns: table => new
            {
                key_section = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                key_lecture = table.Column<int?>(type: "INTEGER", nullable: false),
                key_detail = table.Column<int?>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_section", x => x.key_section);
                table.ForeignKey(
                    name: "fk_section_detail",
                    column: x => x.key_detail,
                    principalTable: "tbl_detail",
                    principalColumn: "key_detail",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_section_lecture",
                    column: x => x.key_lecture,
                    principalTable: "tbl_lecture",
                    principalColumn: "key_lecture",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_publisher",
            columns: table => new
            {
                key_publisher = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_publisher = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false),
                KeyCity = table.Column<int?>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_publisher", x => x.key_publisher);
                table.ForeignKey(
                    name: "fk_state_publisher",
                    column: x => x.KeyCity,
                    principalTable: "tbl_city",
                    principalColumn: "key_city",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_line",
            columns: table => new
            {
                key_line = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                mark_line = table.Column<string>(type: "TEXT", maxLength: 5, nullable: true),
                order_line = table.Column<int?>(type: "INTEGER", nullable: true),
                txt_line = table.Column<string>(type: "TEXT", maxLength: 144, nullable: false),
                KeySection = table.Column<int?>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_line", x => x.key_line);
                table.ForeignKey(
                    name: "fk_section_line",
                    column: x => x.KeySection,
                    principalTable: "tbl_section",
                    principalColumn: "key_section",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_title",
            columns: table => new
            {
                key_title = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                txt_title = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                KeyEdition = table.Column<int?>(type: "INTEGER", nullable: false),
                KeyPublisher = table.Column<int?>(type: "INTEGER", nullable: false),
                KeyLanguage = table.Column<int?>(type: "INTEGER", nullable: false),
                KeyYear = table.Column<int?>(type: "INTEGER", nullable: false),
                KeyDisclaimer = table.Column<int?>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_title", x => x.key_title);
                table.ForeignKey(
                    name: "fk_key_year_title",
                    column: x => x.KeyYear,
                    principalTable: "tbl_year",
                    principalColumn: "key_year",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_title_disclaimer",
                    column: x => x.KeyDisclaimer,
                    principalTable: "tbl_disclaimer",
                    principalColumn: "key_disclaimer",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_title_edition",
                    column: x => x.KeyEdition,
                    principalTable: "tbl_edition",
                    principalColumn: "key_edition",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_title_language",
                    column: x => x.KeyLanguage,
                    principalTable: "tbl_language",
                    principalColumn: "key_language",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_title_publisher",
                    column: x => x.KeyPublisher,
                    principalTable: "tbl_publisher",
                    principalColumn: "key_publisher",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_title_biblio",
            columns: table => new
            {
                key_title_biblio = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                key_title = table.Column<int?>(type: "INTEGER", nullable: false),
                key_biblio = table.Column<int?>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_title_biblio", x => x.key_title_biblio);
                table.ForeignKey(
                    name: "fk_key_title_biblio",
                    column: x => x.key_title,
                    principalTable: "tbl_title",
                    principalColumn: "key_title",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_key_title_biblio_biblio",
                    column: x => x.key_biblio,
                    principalTable: "tbl_biblio",
                    principalColumn: "key_biblio",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateTable(
            name: "tbl_title_url",
            columns: table => new
            {
                key_title_url = table.Column<int?>(type: "INTEGER", nullable: false)
                    .Annotation("Sqlite:Autoincrement", true),
                key_title = table.Column<int?>(type: "INTEGER", nullable: false),
                key_url = table.Column<int?>(type: "INTEGER", nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("pk_key_title_url", x => x.key_title_url);
                table.ForeignKey(
                    name: "fk_key_title_title",
                    column: x => x.key_title,
                    principalTable: "tbl_title",
                    principalColumn: "key_title",
                    onDelete: ReferentialAction.Cascade);
                table.ForeignKey(
                    name: "fk_url_title",
                    column: x => x.key_url,
                    principalTable: "tbl_url",
                    principalColumn: "key_url",
                    onDelete: ReferentialAction.Cascade);
            });

        migrationBuilder.CreateIndex(
            name: "IX_AspNetRoleClaims_RoleId",
            table: "AspNetRoleClaims",
            column: "RoleId");

        migrationBuilder.CreateIndex(
            name: "IX_AspNetUserLogins_UserId",
            table: "AspNetUserLogins",
            column: "UserId");

        migrationBuilder.CreateIndex(
            name: "IX_AspNetUserRoles_RoleId",
            table: "AspNetUserRoles",
            column: "RoleId");

        migrationBuilder.CreateIndex(
            name: "idx_key_author",
            table: "tbl_author",
            column: "key_author",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_biblio",
            table: "tbl_biblio",
            column: "key_biblio",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_biblio_author",
            table: "tbl_biblio_author",
            column: "key_biblio_author",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_biblio_author_author",
            table: "tbl_biblio_author",
            column: "key_author");

        migrationBuilder.CreateIndex(
            name: "idx_key_biblio_author_biblio",
            table: "tbl_biblio_author",
            column: "key_biblio");

        migrationBuilder.CreateIndex(
            name: "idx_key_biblio_image",
            table: "tbl_biblio_image",
            column: "key_biblio_image",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_biblio_image_biblio",
            table: "tbl_biblio_image",
            column: "key_biblio");

        migrationBuilder.CreateIndex(
            name: "idx_key_biblio_image_image",
            table: "tbl_biblio_image",
            column: "key_image");

        migrationBuilder.CreateIndex(
            name: "idx_key_biblio_lecture",
            table: "tbl_biblio_lecture",
            column: "key_biblio_lecture",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_biblio_lecture_biblio",
            table: "tbl_biblio_lecture",
            column: "key_biblio");

        migrationBuilder.CreateIndex(
            name: "idx_key_biblio_lecture_lecture",
            table: "tbl_biblio_lecture",
            column: "key_lecture");

        migrationBuilder.CreateIndex(
            name: "idx_key_city",
            table: "tbl_city",
            column: "key_city",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_city_state",
            table: "tbl_city",
            column: "key_state");

        migrationBuilder.CreateIndex(
            name: "idx_key_country",
            table: "tbl_country",
            column: "key_country",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_course",
            table: "tbl_course",
            column: "key_course",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_course_cycle",
            table: "tbl_course",
            column: "key_cycle");

        migrationBuilder.CreateIndex(
            name: "idx_key_course_duration",
            table: "tbl_course",
            column: "key_duration");

        migrationBuilder.CreateIndex(
            name: "idx_key_course_period",
            table: "tbl_course",
            column: "key_period");

        migrationBuilder.CreateIndex(
            name: "idx_key_course_unit",
            table: "tbl_course",
            column: "key_unit");

        migrationBuilder.CreateIndex(
            name: "idx_key_credit",
            table: "tbl_credit",
            column: "key_credit",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_cycle",
            table: "tbl_cycle",
            column: "key_cycle",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_detail",
            table: "tbl_detail",
            column: "key_detail",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_disclaimer",
            table: "tbl_disclaimer",
            column: "key_disclaimer",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_duration",
            table: "tbl_duration",
            column: "key_duration",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_edition",
            table: "tbl_edition",
            column: "key_edition",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_effort",
            table: "tbl_effort",
            column: "key_effort",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_image",
            table: "tbl_image",
            column: "key_image",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_language",
            table: "tbl_language",
            column: "key_language",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_lecture",
            table: "tbl_lecture",
            column: "key_lecture",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_lecture_credit",
            table: "tbl_lecture",
            column: "key_credit");

        migrationBuilder.CreateIndex(
            name: "idx_key_lecture_effort",
            table: "tbl_lecture",
            column: "key_effort");

        migrationBuilder.CreateIndex(
            name: "idx_key_lecture_type",
            table: "tbl_lecture",
            column: "key_type");

        migrationBuilder.CreateIndex(
            name: "idx_key_lecture_work",
            table: "tbl_lecture",
            column: "key_work");

        migrationBuilder.CreateIndex(
            name: "idx_key_lecture_course",
            table: "tbl_lecture_course",
            column: "key_lecture_course",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_lecture_course_course",
            table: "tbl_lecture_course",
            column: "key_course");

        migrationBuilder.CreateIndex(
            name: "idx_key_lecture_course_lecture",
            table: "tbl_lecture_course",
            column: "key_lecture");

        migrationBuilder.CreateIndex(
            name: "idx_key_lecture_pre",
            table: "tbl_lecture_pre",
            column: "key_lecture_pre",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_lecture_pre_lecture",
            table: "tbl_lecture_pre",
            column: "key_lecture");

        migrationBuilder.CreateIndex(
            name: "idx_key_lecture_pre_pre",
            table: "tbl_lecture_pre",
            column: "key_pre");

        migrationBuilder.CreateIndex(
            name: "idx_key_lecture_teacher",
            table: "tbl_lecture_teacher",
            column: "key_lecture_teacher",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_lecture_teacher_lecture",
            table: "tbl_lecture_teacher",
            column: "key_lecture");

        migrationBuilder.CreateIndex(
            name: "idx_key_lecture_teacher_teacher",
            table: "tbl_lecture_teacher",
            column: "key_teacher");

        migrationBuilder.CreateIndex(
            name: "idx_key_line",
            table: "tbl_line",
            column: "key_line",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_line_section",
            table: "tbl_line",
            column: "KeySection");

        migrationBuilder.CreateIndex(
            name: "idx_key_period",
            table: "tbl_period",
            column: "key_period",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_pre",
            table: "tbl_pre",
            column: "key_pre",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_publisher",
            table: "tbl_publisher",
            column: "key_publisher",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_publisher_city",
            table: "tbl_publisher",
            column: "KeyCity");

        migrationBuilder.CreateIndex(
            name: "idx_id_role",
            table: "tbl_role",
            column: "id_role",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_role",
            table: "tbl_role",
            column: "key_role",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "RoleNameIndex",
            table: "tbl_role",
            column: "NormalizedName",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_section",
            table: "tbl_section",
            column: "key_section",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_section_detail",
            table: "tbl_section",
            column: "key_detail",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_section_lecture",
            table: "tbl_section",
            column: "key_lecture",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_state",
            table: "tbl_state",
            column: "key_state",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_state_country",
            table: "tbl_state",
            column: "key_country");

        migrationBuilder.CreateIndex(
            name: "idx_key_teacher",
            table: "tbl_teacher",
            column: "key_teacher",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_title",
            table: "tbl_title",
            column: "key_title",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_title_disclaimer",
            table: "tbl_title",
            column: "KeyDisclaimer");

        migrationBuilder.CreateIndex(
            name: "idx_key_title_edition",
            table: "tbl_title",
            column: "KeyEdition");

        migrationBuilder.CreateIndex(
            name: "idx_key_title_language",
            table: "tbl_title",
            column: "KeyLanguage");

        migrationBuilder.CreateIndex(
            name: "idx_key_title_publisher",
            table: "tbl_title",
            column: "KeyPublisher");

        migrationBuilder.CreateIndex(
            name: "idx_key_title_year",
            table: "tbl_title",
            column: "KeyYear");

        migrationBuilder.CreateIndex(
            name: "idx_key_title_biblio",
            table: "tbl_title_biblio",
            column: "key_title_biblio",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_title_biblio_biblio",
            table: "tbl_title_biblio",
            column: "key_biblio");

        migrationBuilder.CreateIndex(
            name: "idx_key_title_biblio_title",
            table: "tbl_title_biblio",
            column: "key_title");

        migrationBuilder.CreateIndex(
            name: "idx_key_title_url",
            table: "tbl_title_url",
            column: "key_title_url",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_title_url_title",
            table: "tbl_title_url",
            column: "key_title");

        migrationBuilder.CreateIndex(
            name: "idx_key_title_url_url",
            table: "tbl_title_url",
            column: "key_url");

        migrationBuilder.CreateIndex(
            name: "idx_key_type",
            table: "tbl_type",
            column: "key_type",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_unit",
            table: "tbl_unit",
            column: "key_unit",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_url",
            table: "tbl_url",
            column: "key_url",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "EmailIndex",
            table: "tbl_user",
            column: "NormalizedEmail");

        migrationBuilder.CreateIndex(
            name: "idx_id_user",
            table: "tbl_user",
            column: "id_user",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_user",
            table: "tbl_user",
            column: "key_user",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "UserNameIndex",
            table: "tbl_user",
            column: "NormalizedUserName",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_id_user_claim",
            table: "tbl_user_claim",
            column: "id_user_claim",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_user_claim",
            table: "tbl_user_claim",
            column: "key_user_claim",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_user_id_user_claim",
            table: "tbl_user_claim",
            column: "id_user");

        migrationBuilder.CreateIndex(
            name: "idx_key_work",
            table: "tbl_work",
            column: "key_work",
            unique: true);

        migrationBuilder.CreateIndex(
            name: "idx_key_year",
            table: "tbl_year",
            column: "key_year",
            unique: true);
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "AspNetRoleClaims");

        migrationBuilder.DropTable(
            name: "AspNetUserLogins");

        migrationBuilder.DropTable(
            name: "AspNetUserRoles");

        migrationBuilder.DropTable(
            name: "AspNetUserTokens");

        migrationBuilder.DropTable(
            name: "tbl_biblio_author");

        migrationBuilder.DropTable(
            name: "tbl_biblio_image");

        migrationBuilder.DropTable(
            name: "tbl_biblio_lecture");

        migrationBuilder.DropTable(
            name: "tbl_lecture_course");

        migrationBuilder.DropTable(
            name: "tbl_lecture_pre");

        migrationBuilder.DropTable(
            name: "tbl_lecture_teacher");

        migrationBuilder.DropTable(
            name: "tbl_line");

        migrationBuilder.DropTable(
            name: "tbl_title_biblio");

        migrationBuilder.DropTable(
            name: "tbl_title_url");

        migrationBuilder.DropTable(
            name: "tbl_user_claim");

        migrationBuilder.DropTable(
            name: "tbl_role");

        migrationBuilder.DropTable(
            name: "tbl_author");

        migrationBuilder.DropTable(
            name: "tbl_image");

        migrationBuilder.DropTable(
            name: "tbl_course");

        migrationBuilder.DropTable(
            name: "tbl_pre");

        migrationBuilder.DropTable(
            name: "tbl_teacher");

        migrationBuilder.DropTable(
            name: "tbl_section");

        migrationBuilder.DropTable(
            name: "tbl_biblio");

        migrationBuilder.DropTable(
            name: "tbl_title");

        migrationBuilder.DropTable(
            name: "tbl_url");

        migrationBuilder.DropTable(
            name: "tbl_user");

        migrationBuilder.DropTable(
            name: "tbl_cycle");

        migrationBuilder.DropTable(
            name: "tbl_duration");

        migrationBuilder.DropTable(
            name: "tbl_period");

        migrationBuilder.DropTable(
            name: "tbl_unit");

        migrationBuilder.DropTable(
            name: "tbl_detail");

        migrationBuilder.DropTable(
            name: "tbl_lecture");

        migrationBuilder.DropTable(
            name: "tbl_year");

        migrationBuilder.DropTable(
            name: "tbl_disclaimer");

        migrationBuilder.DropTable(
            name: "tbl_edition");

        migrationBuilder.DropTable(
            name: "tbl_language");

        migrationBuilder.DropTable(
            name: "tbl_publisher");

        migrationBuilder.DropTable(
            name: "tbl_credit");

        migrationBuilder.DropTable(
            name: "tbl_effort");

        migrationBuilder.DropTable(
            name: "tbl_type");

        migrationBuilder.DropTable(
            name: "tbl_work");

        migrationBuilder.DropTable(
            name: "tbl_city");

        migrationBuilder.DropTable(
            name: "tbl_state");

        migrationBuilder.DropTable(
            name: "tbl_country");
    }
}
