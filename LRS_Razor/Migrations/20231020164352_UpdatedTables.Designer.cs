﻿// <auto-generated />
using System;
using LRS_Razor.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LRS_Razor.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231020164352_UpdatedTables")]
    partial class UpdatedTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LRS_Razor.Models.Description", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DefinitionId")
                        .HasColumnType("int");

                    b.Property<string>("inEnglish")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "en-us");

                    b.Property<string>("inSpanish")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "es");

                    b.HasKey("Id");

                    b.HasIndex("DefinitionId")
                        .IsUnique()
                        .HasFilter("[DefinitionId] IS NOT NULL");

                    b.ToTable("Description");

                    b.HasAnnotation("Relational:JsonPropertyName", "description");
                });

            modelBuilder.Entity("LRS_Razor.Models.Name", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DefinitionId")
                        .HasColumnType("int");

                    b.Property<string>("inEnglish")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "en-us");

                    b.Property<string>("inSpanish")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "es");

                    b.HasKey("Id");

                    b.HasIndex("DefinitionId")
                        .IsUnique()
                        .HasFilter("[DefinitionId] IS NOT NULL");

                    b.ToTable("Name");

                    b.HasAnnotation("Relational:JsonPropertyName", "name");
                });

            modelBuilder.Entity("LRS_Razor.Models.StatementInfo", b =>
                {
                    b.Property<Guid?>("Uuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Object")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TimeStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Verb")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Uuid");

                    b.ToTable("StatementInfos");
                });

            modelBuilder.Entity("LRS_Razor.Models.XAPIDefinition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ObjectId")
                        .HasColumnType("int");

                    b.Property<string>("moreInfo")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "moreInfo");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "type");

                    b.HasKey("Id");

                    b.HasIndex("ObjectId")
                        .IsUnique()
                        .HasFilter("[ObjectId] IS NOT NULL");

                    b.ToTable("XAPIDefinition");

                    b.HasAnnotation("Relational:JsonPropertyName", "definition");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiActor", b =>
                {
                    b.Property<int>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActorId"));

                    b.Property<string>("AccountHomePage")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "homePage");

                    b.Property<string>("AccountName")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "AccountName");

                    b.Property<string>("Mbox")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "mbox");

                    b.Property<string>("MboxSha1Sum")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "mbox_sha1sum");

                    b.Property<string>("Member")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "member");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<string>("ObjectType")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "objectType");

                    b.Property<Guid?>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("openid")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "openid");

                    b.HasKey("ActorId");

                    b.HasIndex("Uuid")
                        .IsUnique()
                        .HasFilter("[Uuid] IS NOT NULL");

                    b.ToTable("Actors");

                    b.HasAnnotation("Relational:JsonPropertyName", "actor");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiContext", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "language");

                    b.Property<string>("Platform")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "platform");

                    b.Property<string>("Revision")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "revision");

                    b.Property<Guid?>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Uuid")
                        .IsUnique()
                        .HasFilter("[Uuid] IS NOT NULL");

                    b.ToTable("Contexts");

                    b.HasAnnotation("Relational:JsonPropertyName", "context");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiContextActivities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ContextId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContextId")
                        .IsUnique();

                    b.ToTable("XApiContextActivities");

                    b.HasAnnotation("Relational:JsonPropertyName", "contextActivities");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiObject", b =>
                {
                    b.Property<int>("ObjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObjectId"));

                    b.Property<string>("ObjectIRI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("ObjectType")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "objectType");

                    b.Property<Guid?>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("XApiContextActivitiesId")
                        .HasColumnType("int");

                    b.HasKey("ObjectId");

                    b.HasIndex("Uuid")
                        .IsUnique()
                        .HasFilter("[Uuid] IS NOT NULL");

                    b.HasIndex("XApiContextActivitiesId");

                    b.ToTable("objects");

                    b.HasAnnotation("Relational:JsonPropertyName", "object");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool?>("Completion")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "completion");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "duration");

                    b.Property<string>("Response")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "response");

                    b.Property<bool?>("Success")
                        .HasColumnType("bit")
                        .HasAnnotation("Relational:JsonPropertyName", "success");

                    b.Property<Guid?>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Uuid")
                        .IsUnique()
                        .HasFilter("[Uuid] IS NOT NULL");

                    b.ToTable("Results");

                    b.HasAnnotation("Relational:JsonPropertyName", "result");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ResultId")
                        .HasColumnType("int");

                    b.Property<double?>("Scaled")
                        .HasColumnType("float")
                        .HasAnnotation("Relational:JsonPropertyName", "scaled");

                    b.Property<double?>("max")
                        .HasColumnType("float")
                        .HasAnnotation("Relational:JsonPropertyName", "max");

                    b.Property<double?>("min")
                        .HasColumnType("float")
                        .HasAnnotation("Relational:JsonPropertyName", "min");

                    b.Property<double?>("raw")
                        .HasColumnType("float")
                        .HasAnnotation("Relational:JsonPropertyName", "raw");

                    b.HasKey("Id");

                    b.HasIndex("ResultId")
                        .IsUnique()
                        .HasFilter("[ResultId] IS NOT NULL");

                    b.ToTable("XApiScore");

                    b.HasAnnotation("Relational:JsonPropertyName", "score");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiStatement", b =>
                {
                    b.Property<Guid>("Uuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Timestamp")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "timestamp");

                    b.HasKey("Uuid");

                    b.ToTable("Statements");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiVerb", b =>
                {
                    b.Property<int>("VerbId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VerbId"));

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("VerbIRI")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.HasKey("VerbId");

                    b.HasIndex("Uuid")
                        .IsUnique();

                    b.ToTable("Verbs");

                    b.HasAnnotation("Relational:JsonPropertyName", "verb");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiVerbDisplay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("VerbId")
                        .HasColumnType("int");

                    b.Property<string>("inEnglish")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "en-US");

                    b.Property<string>("inSpanish")
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "es");

                    b.HasKey("Id");

                    b.HasIndex("VerbId")
                        .IsUnique();

                    b.ToTable("XApiVerbDisplay");

                    b.HasAnnotation("Relational:JsonPropertyName", "display");
                });

            modelBuilder.Entity("LRS_Razor.Models.account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<string>("homePage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "homePage");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.HasKey("Id");

                    b.HasIndex("ActorId")
                        .IsUnique();

                    b.ToTable("account");

                    b.HasAnnotation("Relational:JsonPropertyName", "account");
                });

            modelBuilder.Entity("LRS_Razor.Models.Description", b =>
                {
                    b.HasOne("LRS_Razor.Models.XAPIDefinition", "xAPIDefinition")
                        .WithOne("Description")
                        .HasForeignKey("LRS_Razor.Models.Description", "DefinitionId");

                    b.Navigation("xAPIDefinition");
                });

            modelBuilder.Entity("LRS_Razor.Models.Name", b =>
                {
                    b.HasOne("LRS_Razor.Models.XAPIDefinition", "xAPIDefinition")
                        .WithOne("name")
                        .HasForeignKey("LRS_Razor.Models.Name", "DefinitionId");

                    b.Navigation("xAPIDefinition");
                });

            modelBuilder.Entity("LRS_Razor.Models.XAPIDefinition", b =>
                {
                    b.HasOne("LRS_Razor.Models.XApiObject", "XApiObject")
                        .WithOne("Definition")
                        .HasForeignKey("LRS_Razor.Models.XAPIDefinition", "ObjectId");

                    b.Navigation("XApiObject");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiActor", b =>
                {
                    b.HasOne("LRS_Razor.Models.XApiStatement", "xApiStatement")
                        .WithOne("Actor")
                        .HasForeignKey("LRS_Razor.Models.XApiActor", "Uuid");

                    b.Navigation("xApiStatement");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiContext", b =>
                {
                    b.HasOne("LRS_Razor.Models.XApiStatement", "XApiStatement")
                        .WithOne("Context")
                        .HasForeignKey("LRS_Razor.Models.XApiContext", "Uuid");

                    b.Navigation("XApiStatement");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiContextActivities", b =>
                {
                    b.HasOne("LRS_Razor.Models.XApiContext", "xApiContext")
                        .WithOne("ContextActivities")
                        .HasForeignKey("LRS_Razor.Models.XApiContextActivities", "ContextId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("xApiContext");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiObject", b =>
                {
                    b.HasOne("LRS_Razor.Models.XApiStatement", "XApiStatement")
                        .WithOne("Object")
                        .HasForeignKey("LRS_Razor.Models.XApiObject", "Uuid");

                    b.HasOne("LRS_Razor.Models.XApiContextActivities", null)
                        .WithMany("Category")
                        .HasForeignKey("XApiContextActivitiesId");

                    b.Navigation("XApiStatement");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiResult", b =>
                {
                    b.HasOne("LRS_Razor.Models.XApiStatement", "XApiStatement")
                        .WithOne("Result")
                        .HasForeignKey("LRS_Razor.Models.XApiResult", "Uuid");

                    b.Navigation("XApiStatement");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiScore", b =>
                {
                    b.HasOne("LRS_Razor.Models.XApiResult", "XApiResult")
                        .WithOne("Score")
                        .HasForeignKey("LRS_Razor.Models.XApiScore", "ResultId");

                    b.Navigation("XApiResult");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiVerb", b =>
                {
                    b.HasOne("LRS_Razor.Models.XApiStatement", "XApiStatement")
                        .WithOne("Verb")
                        .HasForeignKey("LRS_Razor.Models.XApiVerb", "Uuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("XApiStatement");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiVerbDisplay", b =>
                {
                    b.HasOne("LRS_Razor.Models.XApiVerb", "XApiVerb")
                        .WithOne("Display")
                        .HasForeignKey("LRS_Razor.Models.XApiVerbDisplay", "VerbId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("XApiVerb");
                });

            modelBuilder.Entity("LRS_Razor.Models.account", b =>
                {
                    b.HasOne("LRS_Razor.Models.XApiActor", "xApiActor")
                        .WithOne("account")
                        .HasForeignKey("LRS_Razor.Models.account", "ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("xApiActor");
                });

            modelBuilder.Entity("LRS_Razor.Models.XAPIDefinition", b =>
                {
                    b.Navigation("Description");

                    b.Navigation("name");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiActor", b =>
                {
                    b.Navigation("account");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiContext", b =>
                {
                    b.Navigation("ContextActivities");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiContextActivities", b =>
                {
                    b.Navigation("Category");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiObject", b =>
                {
                    b.Navigation("Definition");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiResult", b =>
                {
                    b.Navigation("Score");
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiStatement", b =>
                {
                    b.Navigation("Actor")
                        .IsRequired();

                    b.Navigation("Context");

                    b.Navigation("Object")
                        .IsRequired();

                    b.Navigation("Result");

                    b.Navigation("Verb")
                        .IsRequired();
                });

            modelBuilder.Entity("LRS_Razor.Models.XApiVerb", b =>
                {
                    b.Navigation("Display");
                });
#pragma warning restore 612, 618
        }
    }
}
