using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LRS_Razor.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTables02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_Actors_ActorId",
                table: "account");

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

            migrationBuilder.DropIndex(
                name: "IX_account_ActorId",
                table: "account");

            migrationBuilder.AlterColumn<int>(
                name: "VerbId",
                table: "XApiVerbDisplay",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "Uuid",
                table: "Verbs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "ActorId",
                table: "account",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateIndex(
                name: "IX_account_ActorId",
                table: "account",
                column: "ActorId",
                unique: true,
                filter: "[ActorId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_account_Actors_ActorId",
                table: "account",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "ActorId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_account_Actors_ActorId",
                table: "account");

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

            migrationBuilder.DropIndex(
                name: "IX_account_ActorId",
                table: "account");

            migrationBuilder.AlterColumn<int>(
                name: "VerbId",
                table: "XApiVerbDisplay",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
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

            migrationBuilder.AlterColumn<int>(
                name: "ActorId",
                table: "account",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                name: "FK_account_Actors_ActorId",
                table: "account",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

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
    }
}
