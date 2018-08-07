namespace Superhero2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Superhero2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Superhero2.Models.SuperheroDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Superhero2.Models.SuperheroDbContext";
        }

        protected override void Seed(Superhero2.Models.SuperheroDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Superheroes.AddOrUpdate(x => x.Id,
        new Superhero() { Id = 1, Name = "Captain Flameworthy", AlterEgo = "Jane Austen", PrimaryPower = "Writing books", SecondaryPower = "Reading books", Catchphrase = "To each his own." },
        new Superhero() { Id = 2, Name = "Deputy Dickens", AlterEgo = "Charles Dickens", PrimaryPower = "Turning things into coal", SecondaryPower = "Eating rocks to boost energy", Catchphrase = "To Picadilly, and beyond!" },
        new Superhero() { Id = 3, Name = "Don Quixotic", AlterEgo = "Miguel Cervantes", PrimaryPower = "Magic lance", SecondaryPower = "Imaginary horse", Catchphrase = "Believe you, me." }
        );

        }
    }
}
