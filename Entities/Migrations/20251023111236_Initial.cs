using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "degree_status",
                columns: table => new
                {
                    degree_status_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    degree_status_name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_degree_status", x => x.degree_status_id);
                });

            migrationBuilder.CreateTable(
                name: "degree_type",
                columns: table => new
                {
                    degree_type_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    degree_type_name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_degree_type", x => x.degree_type_id);
                });

            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    department_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    department_name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department", x => x.department_id);
                });

            migrationBuilder.CreateTable(
                name: "employment_type",
                columns: table => new
                {
                    employment_type_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employment_type_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employment_type", x => x.employment_type_id);
                });

            migrationBuilder.CreateTable(
                name: "experience_level",
                columns: table => new
                {
                    experience_level_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    experience_level = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    experience_description = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_experience_level", x => x.experience_level_id);
                });

            migrationBuilder.CreateTable(
                name: "industry",
                columns: table => new
                {
                    industry_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    industry_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_industry", x => x.industry_id);
                });

            migrationBuilder.CreateTable(
                name: "interview_format",
                columns: table => new
                {
                    interview_format_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    interview_format_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_interview_format", x => x.interview_format_id);
                });

            migrationBuilder.CreateTable(
                name: "InterviewReschedulingReasons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Reason = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewReschedulingReasons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "office_type",
                columns: table => new
                {
                    office_type_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    office_type_name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_office_type", x => x.office_type_id);
                });

            migrationBuilder.CreateTable(
                name: "priority_level",
                columns: table => new
                {
                    priority_level_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    priority_level_name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    priority_level_description = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_priority_level", x => x.priority_level_id);
                });

            migrationBuilder.CreateTable(
                name: "project_category",
                columns: table => new
                {
                    project_category_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    project_category_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project_category", x => x.project_category_id);
                });

            migrationBuilder.CreateTable(
                name: "project_status",
                columns: table => new
                {
                    project_status_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    project_status_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project_status", x => x.project_status_id);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    role_name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.role_id);
                });

            migrationBuilder.CreateTable(
                name: "skill",
                columns: table => new
                {
                    skill_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    skill_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    skill_category_id = table.Column<int>(type: "integer", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skill", x => x.skill_id);
                });

            migrationBuilder.CreateTable(
                name: "skills_category",
                columns: table => new
                {
                    skill_category_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    skill_category_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skills_category", x => x.skill_category_id);
                });

            migrationBuilder.CreateTable(
                name: "status_category",
                columns: table => new
                {
                    status_category_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status_category_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status_category", x => x.status_category_id);
                });

            migrationBuilder.CreateTable(
                name: "sub_role",
                columns: table => new
                {
                    sub_role_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    permission_id = table.Column<int>(type: "integer", nullable: false),
                    sub_role_name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    role_desc = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sub_role", x => x.sub_role_id);
                });

            migrationBuilder.CreateTable(
                name: "work_mode",
                columns: table => new
                {
                    work_mode_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    work_mode_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    created_on = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_work_mode", x => x.work_mode_id);
                });

            migrationBuilder.CreateTable(
                name: "status",
                columns: table => new
                {
                    status_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    status_name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    status_category_id = table.Column<int>(type: "integer", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status", x => x.status_id);
                    table.ForeignKey(
                        name: "FK_status_status_category_status_category_id",
                        column: x => x.status_category_id,
                        principalTable: "status_category",
                        principalColumn: "status_category_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "application",
                columns: table => new
                {
                    application_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    unique_key = table.Column<Guid>(type: "uuid", nullable: false),
                    candidate_id = table.Column<int>(type: "integer", nullable: false),
                    job_id = table.Column<int>(type: "integer", nullable: false),
                    ScreeningJson = table.Column<string>(type: "text", nullable: true),
                    is_offer_sent = table.Column<int>(type: "integer", nullable: true),
                    is_offer_accepted = table.Column<int>(type: "integer", nullable: true),
                    experience_and_background = table.Column<string>(type: "jsonb", nullable: true),
                    resume_path = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    match_percentage = table.Column<int>(type: "integer", nullable: true),
                    applied_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    application_status_id = table.Column<int>(type: "integer", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_by = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_application", x => x.application_id);
                    table.ForeignKey(
                        name: "FK_application_status_application_status_id",
                        column: x => x.application_status_id,
                        principalTable: "status",
                        principalColumn: "status_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "application_history",
                columns: table => new
                {
                    application_history_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    unique_key = table.Column<Guid>(type: "uuid", nullable: false),
                    application_id = table.Column<int>(type: "integer", nullable: false),
                    status_id = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_application_history", x => x.application_history_id);
                    table.ForeignKey(
                        name: "FK_application_history_application_application_id",
                        column: x => x.application_id,
                        principalTable: "application",
                        principalColumn: "application_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "scheduled_interview",
                columns: table => new
                {
                    scheduled_interview_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    unique_key = table.Column<Guid>(type: "uuid", nullable: false),
                    application_id = table.Column<int>(type: "integer", nullable: false),
                    parent_interview_id = table.Column<int>(type: "integer", nullable: true),
                    interview_format_id = table.Column<int>(type: "integer", nullable: false),
                    interview_mode = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    scheduled_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    start_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    duration = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    interview_feedback = table.Column<string>(type: "json", nullable: true),
                    location = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_by = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scheduled_interview", x => x.scheduled_interview_id);
                    table.ForeignKey(
                        name: "FK_scheduled_interview_application_application_id",
                        column: x => x.application_id,
                        principalTable: "application",
                        principalColumn: "application_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "candidate",
                columns: table => new
                {
                    candidate_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    unique_key = table.Column<Guid>(type: "uuid", nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    resume_path = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    overall_experience = table.Column<int>(type: "integer", nullable: true),
                    candidate_profile = table.Column<string>(type: "jsonb", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_by = table.Column<int>(type: "integer", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidate", x => x.candidate_id);
                });

            migrationBuilder.CreateTable(
                name: "job",
                columns: table => new
                {
                    job_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    unique_key = table.Column<Guid>(type: "uuid", nullable: false),
                    job_title = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    interview_process = table.Column<string>(type: "jsonb", nullable: true),
                    department_id = table.Column<int>(type: "integer", nullable: false),
                    location_id = table.Column<int>(type: "integer", nullable: false),
                    employment_type_id = table.Column<int>(type: "integer", nullable: false),
                    organisation_id = table.Column<int>(type: "integer", nullable: false),
                    work_mode_id = table.Column<int>(type: "integer", nullable: false),
                    min_salary = table.Column<long>(type: "bigint", nullable: true),
                    max_salary = table.Column<long>(type: "bigint", nullable: true),
                    job_desc = table.Column<string>(type: "json", nullable: true),
                    job_status_id = table.Column<int>(type: "integer", nullable: false),
                    experience_level_id = table.Column<int>(type: "integer", nullable: false),
                    priority_level_id = table.Column<int>(type: "integer", nullable: false),
                    job_deadline_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_by = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    PriorityLevelNavigationId = table.Column<int>(type: "integer", nullable: false),
                    OfficeLocId = table.Column<int>(type: "integer", nullable: true),
                    WorkModeId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job", x => x.job_id);
                    table.ForeignKey(
                        name: "FK_job_department_department_id",
                        column: x => x.department_id,
                        principalTable: "department",
                        principalColumn: "department_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_job_employment_type_employment_type_id",
                        column: x => x.employment_type_id,
                        principalTable: "employment_type",
                        principalColumn: "employment_type_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_job_experience_level_experience_level_id",
                        column: x => x.experience_level_id,
                        principalTable: "experience_level",
                        principalColumn: "experience_level_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_job_priority_level_PriorityLevelNavigationId",
                        column: x => x.PriorityLevelNavigationId,
                        principalTable: "priority_level",
                        principalColumn: "priority_level_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_job_work_mode_WorkModeId",
                        column: x => x.WorkModeId,
                        principalTable: "work_mode",
                        principalColumn: "work_mode_id");
                });

            migrationBuilder.CreateTable(
                name: "job_draft",
                columns: table => new
                {
                    job_draft_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    job_id = table.Column<int>(type: "integer", nullable: false),
                    job_title = table.Column<string>(type: "text", nullable: true),
                    department_id = table.Column<int>(type: "integer", nullable: true),
                    interview_process = table.Column<string>(type: "jsonb", nullable: true),
                    location_id = table.Column<int>(type: "integer", nullable: true),
                    emp_type_id = table.Column<int>(type: "integer", nullable: true),
                    organisation_id = table.Column<int>(type: "integer", nullable: true),
                    work_mode_id = table.Column<int>(type: "integer", nullable: true),
                    min_salary = table.Column<long>(type: "bigint", nullable: true),
                    max_salary = table.Column<long>(type: "bigint", nullable: true),
                    job_desc = table.Column<string>(type: "json", nullable: true),
                    job_status_id = table.Column<int>(type: "integer", nullable: true),
                    experience_level_id = table.Column<int>(type: "integer", nullable: true),
                    priority_level_id = table.Column<int>(type: "integer", nullable: true),
                    job_deadline_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    created_by = table.Column<string>(type: "text", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_by = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job_draft", x => x.job_draft_id);
                    table.ForeignKey(
                        name: "FK_job_draft_job_job_id",
                        column: x => x.job_id,
                        principalTable: "job",
                        principalColumn: "job_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "saved_job",
                columns: table => new
                {
                    saved_job_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    candidate_id = table.Column<int>(type: "integer", nullable: false),
                    job_id = table.Column<int>(type: "integer", nullable: false),
                    is_applied = table.Column<int>(type: "integer", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_by = table.Column<int>(type: "integer", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_saved_job", x => x.saved_job_id);
                    table.ForeignKey(
                        name: "FK_saved_job_candidate_candidate_id",
                        column: x => x.candidate_id,
                        principalTable: "candidate",
                        principalColumn: "candidate_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_saved_job_job_job_id",
                        column: x => x.job_id,
                        principalTable: "job",
                        principalColumn: "job_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "job_history",
                columns: table => new
                {
                    job_history_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    job_id = table.Column<int>(type: "integer", nullable: false),
                    job_status_id = table.Column<int>(type: "integer", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_job_history", x => x.job_history_id);
                    table.ForeignKey(
                        name: "FK_job_history_job_job_id",
                        column: x => x.job_id,
                        principalTable: "job",
                        principalColumn: "job_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_job_history_status_job_status_id",
                        column: x => x.job_status_id,
                        principalTable: "status",
                        principalColumn: "status_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "office_loc",
                columns: table => new
                {
                    office_loc_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    unique_key = table.Column<Guid>(type: "uuid", nullable: false),
                    organisation_id = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    office_info = table.Column<string>(type: "json", nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_by = table.Column<int>(type: "integer", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_office_loc", x => x.office_loc_id);
                });

            migrationBuilder.CreateTable(
                name: "organisation",
                columns: table => new
                {
                    organisation_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    unique_key = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    industry = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    overview = table.Column<string>(type: "jsonb", nullable: true),
                    culture = table.Column<string>(type: "jsonb", nullable: true),
                    benefit = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    office_loc_id = table.Column<int>(type: "integer", nullable: false),
                    organisation_status = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_by = table.Column<int>(type: "integer", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organisation", x => x.organisation_id);
                    table.ForeignKey(
                        name: "FK_organisation_office_loc_office_loc_id",
                        column: x => x.office_loc_id,
                        principalTable: "office_loc",
                        principalColumn: "office_loc_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    user_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    unique_key = table.Column<Guid>(type: "uuid", nullable: false),
                    first_name = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    last_name = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    location = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    password = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    last_login_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_by = table.Column<int>(type: "integer", nullable: true),
                    updated_by = table.Column<int>(type: "integer", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    OrganisationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.user_id);
                    table.ForeignKey(
                        name: "FK_user_organisation_OrganisationId",
                        column: x => x.OrganisationId,
                        principalTable: "organisation",
                        principalColumn: "organisation_id");
                });

            migrationBuilder.CreateTable(
                name: "organisation_team",
                columns: table => new
                {
                    organisation_team_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    unique_key = table.Column<Guid>(type: "uuid", nullable: false),
                    first_name = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    last_name = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    email = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    sub_role_id = table.Column<int>(type: "integer", nullable: false),
                    department_id = table.Column<int>(type: "integer", nullable: false),
                    message = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updated_by = table.Column<int>(type: "integer", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organisation_team", x => x.organisation_team_id);
                    table.ForeignKey(
                        name: "FK_organisation_team_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "scheduled_interview_history",
                columns: table => new
                {
                    scheduled_interview_history_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    scheduled_interview_id = table.Column<int>(type: "integer", nullable: false),
                    status_id = table.Column<int>(type: "integer", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scheduled_interview_history", x => x.scheduled_interview_history_id);
                    table.ForeignKey(
                        name: "FK_scheduled_interview_history_scheduled_interview_scheduled_i~",
                        column: x => x.scheduled_interview_id,
                        principalTable: "scheduled_interview",
                        principalColumn: "scheduled_interview_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_scheduled_interview_history_status_status_id",
                        column: x => x.status_id,
                        principalTable: "status",
                        principalColumn: "status_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_scheduled_interview_history_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_role_mapping",
                columns: table => new
                {
                    user_role_mapping_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    role_id = table.Column<int>(type: "integer", nullable: false),
                    sub_role_id = table.Column<int>(type: "integer", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    deleted_by = table.Column<int>(type: "integer", nullable: true),
                    updated_by = table.Column<int>(type: "integer", nullable: true),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_role_mapping", x => x.user_role_mapping_id);
                    table.ForeignKey(
                        name: "FK_user_role_mapping_role_role_id",
                        column: x => x.role_id,
                        principalTable: "role",
                        principalColumn: "role_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_role_mapping_sub_role_sub_role_id",
                        column: x => x.sub_role_id,
                        principalTable: "sub_role",
                        principalColumn: "sub_role_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_role_mapping_user_user_id",
                        column: x => x.user_id,
                        principalTable: "user",
                        principalColumn: "user_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_application_application_status_id",
                table: "application",
                column: "application_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_application_candidate_id",
                table: "application",
                column: "candidate_id");

            migrationBuilder.CreateIndex(
                name: "IX_application_job_id",
                table: "application",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "IX_application_history_application_id",
                table: "application_history",
                column: "application_id");

            migrationBuilder.CreateIndex(
                name: "IX_candidate_user_id",
                table: "candidate",
                column: "user_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_job_department_id",
                table: "job",
                column: "department_id");

            migrationBuilder.CreateIndex(
                name: "IX_job_employment_type_id",
                table: "job",
                column: "employment_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_job_experience_level_id",
                table: "job",
                column: "experience_level_id");

            migrationBuilder.CreateIndex(
                name: "IX_job_OfficeLocId",
                table: "job",
                column: "OfficeLocId");

            migrationBuilder.CreateIndex(
                name: "IX_job_organisation_id",
                table: "job",
                column: "organisation_id");

            migrationBuilder.CreateIndex(
                name: "IX_job_PriorityLevelNavigationId",
                table: "job",
                column: "PriorityLevelNavigationId");

            migrationBuilder.CreateIndex(
                name: "IX_job_WorkModeId",
                table: "job",
                column: "WorkModeId");

            migrationBuilder.CreateIndex(
                name: "IX_job_draft_job_id",
                table: "job_draft",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "IX_job_history_job_id",
                table: "job_history",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "IX_job_history_job_status_id",
                table: "job_history",
                column: "job_status_id");

            migrationBuilder.CreateIndex(
                name: "IX_job_history_UserId",
                table: "job_history",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_office_loc_created_by",
                table: "office_loc",
                column: "created_by");

            migrationBuilder.CreateIndex(
                name: "IX_office_loc_organisation_id",
                table: "office_loc",
                column: "organisation_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_office_loc_updated_by",
                table: "office_loc",
                column: "updated_by");

            migrationBuilder.CreateIndex(
                name: "IX_organisation_office_loc_id",
                table: "organisation",
                column: "office_loc_id");

            migrationBuilder.CreateIndex(
                name: "IX_organisation_team_UserId",
                table: "organisation_team",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_saved_job_candidate_id",
                table: "saved_job",
                column: "candidate_id");

            migrationBuilder.CreateIndex(
                name: "IX_saved_job_job_id",
                table: "saved_job",
                column: "job_id");

            migrationBuilder.CreateIndex(
                name: "IX_scheduled_interview_application_id",
                table: "scheduled_interview",
                column: "application_id");

            migrationBuilder.CreateIndex(
                name: "IX_scheduled_interview_history_scheduled_interview_id",
                table: "scheduled_interview_history",
                column: "scheduled_interview_id");

            migrationBuilder.CreateIndex(
                name: "IX_scheduled_interview_history_status_id",
                table: "scheduled_interview_history",
                column: "status_id");

            migrationBuilder.CreateIndex(
                name: "IX_scheduled_interview_history_UserId",
                table: "scheduled_interview_history",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_status_status_category_id",
                table: "status",
                column: "status_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_OrganisationId",
                table: "user",
                column: "OrganisationId");

            migrationBuilder.CreateIndex(
                name: "IX_user_role_mapping_role_id",
                table: "user_role_mapping",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_role_mapping_sub_role_id",
                table: "user_role_mapping",
                column: "sub_role_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_role_mapping_user_id",
                table: "user_role_mapping",
                column: "user_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_application_candidate_candidate_id",
                table: "application",
                column: "candidate_id",
                principalTable: "candidate",
                principalColumn: "candidate_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_application_job_job_id",
                table: "application",
                column: "job_id",
                principalTable: "job",
                principalColumn: "job_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_candidate_user_user_id",
                table: "candidate",
                column: "user_id",
                principalTable: "user",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_job_office_loc_OfficeLocId",
                table: "job",
                column: "OfficeLocId",
                principalTable: "office_loc",
                principalColumn: "office_loc_id");

            migrationBuilder.AddForeignKey(
                name: "FK_job_organisation_organisation_id",
                table: "job",
                column: "organisation_id",
                principalTable: "organisation",
                principalColumn: "organisation_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_job_history_user_UserId",
                table: "job_history",
                column: "UserId",
                principalTable: "user",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_office_loc_organisation_organisation_id",
                table: "office_loc",
                column: "organisation_id",
                principalTable: "organisation",
                principalColumn: "organisation_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_office_loc_user_created_by",
                table: "office_loc",
                column: "created_by",
                principalTable: "user",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_office_loc_user_updated_by",
                table: "office_loc",
                column: "updated_by",
                principalTable: "user",
                principalColumn: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_office_loc_user_created_by",
                table: "office_loc");

            migrationBuilder.DropForeignKey(
                name: "FK_office_loc_user_updated_by",
                table: "office_loc");

            migrationBuilder.DropForeignKey(
                name: "FK_organisation_office_loc_office_loc_id",
                table: "organisation");

            migrationBuilder.DropTable(
                name: "application_history");

            migrationBuilder.DropTable(
                name: "degree_status");

            migrationBuilder.DropTable(
                name: "degree_type");

            migrationBuilder.DropTable(
                name: "industry");

            migrationBuilder.DropTable(
                name: "interview_format");

            migrationBuilder.DropTable(
                name: "InterviewReschedulingReasons");

            migrationBuilder.DropTable(
                name: "job_draft");

            migrationBuilder.DropTable(
                name: "job_history");

            migrationBuilder.DropTable(
                name: "office_type");

            migrationBuilder.DropTable(
                name: "organisation_team");

            migrationBuilder.DropTable(
                name: "project_category");

            migrationBuilder.DropTable(
                name: "project_status");

            migrationBuilder.DropTable(
                name: "saved_job");

            migrationBuilder.DropTable(
                name: "scheduled_interview_history");

            migrationBuilder.DropTable(
                name: "skill");

            migrationBuilder.DropTable(
                name: "skills_category");

            migrationBuilder.DropTable(
                name: "user_role_mapping");

            migrationBuilder.DropTable(
                name: "scheduled_interview");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "sub_role");

            migrationBuilder.DropTable(
                name: "application");

            migrationBuilder.DropTable(
                name: "candidate");

            migrationBuilder.DropTable(
                name: "job");

            migrationBuilder.DropTable(
                name: "status");

            migrationBuilder.DropTable(
                name: "department");

            migrationBuilder.DropTable(
                name: "employment_type");

            migrationBuilder.DropTable(
                name: "experience_level");

            migrationBuilder.DropTable(
                name: "priority_level");

            migrationBuilder.DropTable(
                name: "work_mode");

            migrationBuilder.DropTable(
                name: "status_category");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "office_loc");

            migrationBuilder.DropTable(
                name: "organisation");
        }
    }
}
