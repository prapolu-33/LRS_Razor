using Microsoft.EntityFrameworkCore;
using LRS_Razor.Models;
using System;

namespace LRS_Razor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<XApiActor> Actors { get; set; }
        public DbSet<XApiVerb> Verbs { get; set; }
        public DbSet<XApiObject> objects { get; set; }
        public DbSet<XApiContext> Contexts { get; set; }
        public DbSet<XApiResult> Results { get; set; }
        public DbSet<XApiStatement> Statements { get; set; }
        public DbSet<StatementInfo> StatementInfos { get; set; }
    }
}


/*modelBuilder.Entity<XApiStatement>()
                .HasOne(m => m.Actor)
                .WithOne()
                .HasForeignKey<XApiObject>(m => m.ActorId);
            modelBuilder.Entity<XApiStatement>()
            .HasOne(s => s.Verb)
            .WithOne()
            .HasForeignKey<XApiStatement>(s => s.VerbId);

            modelBuilder.Entity<XApiStatement>()
                .HasOne(s => s.Object)
                .WithOne()
                .HasForeignKey<XApiStatement>(s => s.ObjectId);*/


/*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the relationship between MyModel and MyObject
            modelBuilder.Entity<XApiStatement>(s =>
            {

                s.OwnsOne(e => e.Actor);

                s.HasOne(e => e.Verb).WithOne().IsRequired();

                s.HasOne(e => e.Object).WithOne().IsRequired();

                s.HasOne(e => e.Result).WithOne().IsRequired();

                s.HasOne(e => e.Context).WithOne().IsRequired();


            });

        }*/


/*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<XAPIDefinition>()
        .HasOne(x => x.Description)
        .WithOne(d => d.xAPIDefinition)
        .HasForeignKey<Description>(d => d.DefinitionId);

            modelBuilder.Entity<Description>()
           .HasOne(d => d.xAPIDefinition)
           .WithOne(x => x.Description)
           .HasForeignKey<XAPIDefinition>(x => x.ObjectId);

            modelBuilder.Entity<XAPIDefinition>()
        .HasOne(x => x.name)
        .WithOne(d => d.xAPIDefinition)
        .HasForeignKey<Description>(d => d.DefinitionId);


            modelBuilder.Entity<Name>()
           .HasOne(d => d.xAPIDefinition)
           .WithOne(x => x.name)
           .HasForeignKey<XAPIDefinition>(x => x.ObjectId);

        }*/