namespace SimpleBookStoreApi.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleBookStoreApi.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(SimpleBookStoreApi.Models.ApplicationDbContext context)
        {

            context.Books.AddOrUpdate(b => b.ID, 
             new Book()
            {
                ID = Guid.Parse("4aec419e-082f-4d9f-a000-4ccc4b655000"),
                Author = "George Raymond Richard Martin",
                Title = "A Game of Thrones",
                Description = "Summers span decades. Winter can last a lifetime. And the struggle for the Iron Throne has begun. As Warden of the north, Lord Eddard Stark counts it a curse when King Robert bestows on him the office of the Hand. His honour weighs him down at court where a true man does what he will, not what he must … and a dead enemy is a thing of beauty. The old gods have no power in the south, Stark’s family is split and there is treachery at court. Worse, the vengeance-mad heir of the deposed Dragon King has grown to maturity in exile in the Free Cities. He claims the Iron Throne.",
                PublicationYear = 1996,
                ImageUrl = "https://upload.wikimedia.org/wikipedia/ru/f/ff/A_Game_of_Thrones_first_cover_UK.jpg"
            },
             new Book()
             {
                 ID = Guid.Parse("4aec419e-082f-4d9f-a000-4ccc4b655001"),
                 Author = "J. K. Rowling",
                 Title = "Harry Potter and the Philosopher's Stone",
                 Description = "Rescued from the outrageous neglect of his aunt and uncle, a young boy with a great destiny proves his worth while attending Hogwarts School of Witchcraft and Wizardry.",
                 PublicationYear = 1998,
                 ImageUrl = "https://upload.wikimedia.org/wikipedia/en/6/6b/Harry_Potter_and_the_Philosopher%27s_Stone_Book_Cover.jpg"
             });

        }
    }
}
