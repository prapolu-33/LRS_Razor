using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LRS_Razor.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Verbs_Statements_Uuid",
                table: "Verbs");

            migrationBuilder.DropForeignKey(
                name: "FK_XApiVerbDisplay_Verbs_VerbId",
                table: "XApiVerbDisplay");

            migrationBuilder.DropIndex(
                name: "IX_XApiVerbDisplay_VerbId",
                table: "XApiVerbDisplay");

            migrationBuilder.DropIndex(
                name: "IX_Verbs_Uuid",
                table: "Verbs");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "objects");

            migrationBuilder.RenameColumn(
                name: "LanguageCode",
                table: "XApiVerbDisplay",
                newName: "inSpanish");

            migrationBuilder.RenameColumn(
                name: "DisplayText",
                table: "XApiVerbDisplay",
                newName: "inEnglish");

            migrationBuilder.RenameColumn(
                name: "ObjectName",
                table: "StatementInfos",
                newName: "Verb");

            migrationBuilder.RenameColumn(
                name: "DisplayText",
                table: "StatementInfos",
                newName: "Object");

            migrationBuilder.RenameColumn(
                name: "ObjectName",
                table: "Name",
                newName: "inSpanish");

            migrationBuilder.RenameColumn(
                name: "conent",
                table: "Description",
                newName: "inSpanish");

            migrationBuilder.AlterColumn<int>(
                name: "VerbId",
                table: "XApiVerbDisplay",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "max",
                table: "XApiScore",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "min",
                table: "XApiScore",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "raw",
                table: "XApiScore",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "moreInfo",
                table: "XAPIDefinition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VerbIRI",
                table: "Verbs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "Uuid",
                table: "Verbs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Completion",
                table: "Results",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "Results",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Response",
                table: "Results",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Success",
                table: "Results",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ObjectIRI",
                table: "objects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "inEnglish",
                table: "Name",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "inEnglish",
                table: "Description",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Contexts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Platform",
                table: "Contexts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Revision",
                table: "Contexts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ObjectType",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Mbox",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "openid",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    homePage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_account_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_XApiVerbDisplay_VerbId",
                table: "XApiVerbDisplay",
                column: "VerbId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Verbs_Uuid",
                table: "Verbs",
                column: "Uuid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_account_ActorId",
                table: "account",
                column: "ActorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Verbs_Statements_Uuid",
                table: "Verbs",
                column: "Uuid",
                principalTable: "Statements",
                principalColumn: "Uuid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_XApiVerbDisplay_Verbs_VerbId",
                table: "XApiVerbDisplay",
                column: "VerbId",
                principalTable: "Verbs",
                principalColumn: "VerbId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Verbs_Statements_Uuid",
                table: "Verbs");

            migrationBuilder.DropForeignKey(
                name: "FK_XApiVerbDisplay_Verbs_VerbId",
                table: "XApiVerbDisplay");

            migrationBuilder.DropTable(
                name: "account");

            migrationBuilder.DropIndex(
                name: "IX_XApiVerbDisplay_VerbId",
                table: "XApiVerbDisplay");

            migrationBuilder.DropIndex(
                name: "IX_Verbs_Uuid",
                table: "Verbs");

            migrationBuilder.DropColumn(
                name: "max",
                table: "XApiScore");

            migrationBuilder.DropColumn(
                name: "min",
                table: "XApiScore");

            migrationBuilder.DropColumn(
                name: "raw",
                table: "XApiScore");

            migrationBuilder.DropColumn(
                name: "moreInfo",
                table: "XAPIDefinition");

            migrationBuilder.DropColumn(
                name: "Completion",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "Response",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "Success",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "ObjectIRI",
                table: "objects");

            migrationBuilder.DropColumn(
                name: "inEnglish",
                table: "Name");

            migrationBuilder.DropColumn(
                name: "inEnglish",
                table: "Description");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Contexts");

            migrationBuilder.DropColumn(
                name: "Platform",
                table: "Contexts");

            migrationBuilder.DropColumn(
                name: "Revision",
                table: "Contexts");

            migrationBuilder.DropColumn(
                name: "openid",
                table: "Actors");

            migrationBuilder.RenameColumn(
                name: "inSpanish",
                table: "XApiVerbDisplay",
                newName: "LanguageCode");

            migrationBuilder.RenameColumn(
                name: "inEnglish",
                table: "XApiVerbDisplay",
                newName: "DisplayText");

            migrationBuilder.RenameColumn(
                name: "Verb",
                table: "StatementInfos",
                newName: "ObjectName");

            migrationBuilder.RenameColumn(
                name: "Object",
                table: "StatementInfos",
                newName: "DisplayText");

            migrationBuilder.RenameColumn(
                name: "inSpanish",
                table: "Name",
                newName: "ObjectName");

            migrationBuilder.RenameColumn(
                name: "inSpanish",
                table: "Description",
                newName: "conent");

            migrationBuilder.AlterColumn<int>(
                name: "VerbId",
                table: "XApiVerbDisplay",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "VerbIRI",
                table: "Verbs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "Uuid",
                table: "Verbs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "objects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ObjectType",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Mbox",
                table: "Actors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_XApiVerbDisplay_VerbId",
                table: "XApiVerbDisplay",
                column: "VerbId",
                unique: true,
                filter: "[VerbId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Verbs_Uuid",
                table: "Verbs",
                column: "Uuid",
                unique: true,
                filter: "[Uuid] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Verbs_Statements_Uuid",
                table: "Verbs",
                column: "Uuid",
                principalTable: "Statements",
                principalColumn: "Uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_XApiVerbDisplay_Verbs_VerbId",
                table: "XApiVerbDisplay",
                column: "VerbId",
                principalTable: "Verbs",
                principalColumn: "VerbId");
        }
    }
}
