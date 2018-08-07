using System.Data.Entity;


namespace Superhero2.Models
{
    public class Superhero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AlterEgo { get; set; }
        public string PrimaryPower { get; set; }
        public string SecondaryPower { get; set; }
        public string Catchphrase { get; set; }
    }

    public class SuperheroDbContext : DbContext
    {
        public DbSet<Superhero>Superheroes { get; set; }
    }
}