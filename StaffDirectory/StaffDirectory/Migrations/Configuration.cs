namespace StaffDirectory.Migrations
{
    using StaffDirectory.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StaffDirectory.DataAccess.PersonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StaffDirectory.DataAccess.PersonContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.People.AddOrUpdate(
                p => p.name,
                new Person { name = "John Smith", email = "JohnSmith@gmail.com", phoneNumber = 08454348231 },
                new Person { name = "Jane Smith", email = "JaneSmith@gmail.com", phoneNumber = 08454348232 },
                new Person { name = "Bob Smith", email = "BobSmith@gmail.com", phoneNumber = 08454348233 },
                new Person { name = "Billy Smith", email = "BillySmith@gmail.com", phoneNumber = 08454348234 },
                new Person { name = "George Smith", email = "GeorgeSmith@gmail.com", phoneNumber = 08454348235 },
                new Person { name = "Sam Smith", email = "samSmith@gmail.com", phoneNumber = 08454348236 },
                new Person { name = "Jess Smith", email = "JessSmith@gmail.com", phoneNumber = 08454348237 }
                );
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

       
    }
}
