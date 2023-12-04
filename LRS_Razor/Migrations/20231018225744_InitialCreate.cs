using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LRS_Razor.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "statementFromSps",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mbox = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerbId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObjectType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Definition_Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statementFromSps", x => x.Uuid);
                });

            migrationBuilder.CreateTable(
                name: "Statements",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Timestamp = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statements", x => x.Uuid);
                });

            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjectType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mbox = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MboxSha1Sum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountHomePage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Member = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorId);
                    table.ForeignKey(
                        name: "FK_Actors_Statements_Uuid",
                        column: x => x.Uuid,
                        principalTable: "Statements",
                        principalColumn: "Uuid");
                });

            migrationBuilder.CreateTable(
                name: "Contexts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contexts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contexts_Statements_Uuid",
                        column: x => x.Uuid,
                        principalTable: "Statements",
                        principalColumn: "Uuid");
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Results_Statements_Uuid",
                        column: x => x.Uuid,
                        principalTable: "Statements",
                        principalColumn: "Uuid");
                });

            migrationBuilder.CreateTable(
                name: "Verbs",
                columns: table => new
                {
                    VerbId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VerbIRI = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verbs", x => x.VerbId);
                    table.ForeignKey(
                        name: "FK_Verbs_Statements_Uuid",
                        column: x => x.Uuid,
                        principalTable: "Statements",
                        principalColumn: "Uuid");
                });

            migrationBuilder.CreateTable(
                name: "XApiContextActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContextId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XApiContextActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_XApiContextActivities_Contexts_ContextId",
                        column: x => x.ContextId,
                        principalTable: "Contexts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "XApiScore",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Scaled = table.Column<double>(type: "float", nullable: true),
                    ResultId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XApiScore", x => x.Id);
                    table.ForeignKey(
                        name: "FK_XApiScore_Results_ResultId",
                        column: x => x.ResultId,
                        principalTable: "Results",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "XApiVerbDisplay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerbId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XApiVerbDisplay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_XApiVerbDisplay_Verbs_VerbId",
                        column: x => x.VerbId,
                        principalTable: "Verbs",
                        principalColumn: "VerbId");
                });

            migrationBuilder.CreateTable(
                name: "objects",
                columns: table => new
                {
                    ObjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObjectType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    XApiContextActivitiesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_objects", x => x.ObjectId);
                    table.ForeignKey(
                        name: "FK_objects_Statements_Uuid",
                        column: x => x.Uuid,
                        principalTable: "Statements",
                        principalColumn: "Uuid");
                    table.ForeignKey(
                        name: "FK_objects_XApiContextActivities_XApiContextActivitiesId",
                        column: x => x.XApiContextActivitiesId,
                        principalTable: "XApiContextActivities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "XAPIDefinition",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ObjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XAPIDefinition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_XAPIDefinition_objects_ObjectId",
                        column: x => x.ObjectId,
                        principalTable: "objects",
                        principalColumn: "ObjectId");
                });

            migrationBuilder.CreateTable(
                name: "Description",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    conent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefinitionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Description", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Description_XAPIDefinition_DefinitionId",
                        column: x => x.DefinitionId,
                        principalTable: "XAPIDefinition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Name",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DefinitionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Name", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Name_XAPIDefinition_DefinitionId",
                        column: x => x.DefinitionId,
                        principalTable: "XAPIDefinition",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_Uuid",
                table: "Actors",
                column: "Uuid",
                unique: true,
                filter: "[Uuid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Contexts_Uuid",
                table: "Contexts",
                column: "Uuid",
                unique: true,
                filter: "[Uuid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Description_DefinitionId",
                table: "Description",
                column: "DefinitionId",
                unique: true,
                filter: "[DefinitionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Name_DefinitionId",
                table: "Name",
                column: "DefinitionId",
                unique: true,
                filter: "[DefinitionId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_objects_Uuid",
                table: "objects",
                column: "Uuid",
                unique: true,
                filter: "[Uuid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_objects_XApiContextActivitiesId",
                table: "objects",
                column: "XApiContextActivitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Results_Uuid",
                table: "Results",
                column: "Uuid",
                unique: true,
                filter: "[Uuid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Verbs_Uuid",
                table: "Verbs",
                column: "Uuid",
                unique: true,
                filter: "[Uuid] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_XApiContextActivities_ContextId",
                table: "XApiContextActivities",
                column: "ContextId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_XAPIDefinition_ObjectId",
                table: "XAPIDefinition",
                column: "ObjectId",
                unique: true,
                filter: "[ObjectId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_XApiScore_ResultId",
                table: "XApiScore",
                column: "ResultId",
                unique: true,
                filter: "[ResultId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_XApiVerbDisplay_VerbId",
                table: "XApiVerbDisplay",
                column: "VerbId",
                unique: true,
                filter: "[VerbId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Description");

            migrationBuilder.DropTable(
                name: "Name");

            migrationBuilder.DropTable(
                name: "statementFromSps");

            migrationBuilder.DropTable(
                name: "XApiScore");

            migrationBuilder.DropTable(
                name: "XApiVerbDisplay");

            migrationBuilder.DropTable(
                name: "XAPIDefinition");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "Verbs");

            migrationBuilder.DropTable(
                name: "objects");

            migrationBuilder.DropTable(
                name: "XApiContextActivities");

            migrationBuilder.DropTable(
                name: "Contexts");

            migrationBuilder.DropTable(
                name: "Statements");
        }
    }
}
