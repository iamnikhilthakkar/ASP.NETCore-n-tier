using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetitionPulse.Repository.Entities
{
    public class PetitionPulseContext : DbContext
    {
        public PetitionPulseContext(DbContextOptions<PetitionPulseContext> options)
            : base(options)
        {

        }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //SeedTopic(modelBuilder);
        }

        public void SeedTopic(ModelBuilder modelBuilder)
        {
            var topicNames = new List<string>() { "Animal Rights and Conservation", "Business and Economy", "Child and Family Well-Being", "Criminal Justice", "Disability", "Education", "Elder Rights", "Entertainment & Media", "Environmental Issues", "Ethnic and Racial Minorities", "Government and Politics", "Health and Well-Being", "Immigrants", "LGBTQ", "Public Safety", "Religion", "Sport", "Technology", "Veterans", "Women's Rights", "Other" };

            int id = 1;
            foreach (var topic in topicNames)
            {
                modelBuilder.Entity<Topic>().HasData(new Topic
                {
                    ID = id,
                    TopicName = topic,
                    Status = true,
                    CreatedDate = DateTime.UtcNow
                });
                
                id++;
            }
            ////modelBuilder.Entity<Topic>().HasData(new Topic
            ////{
            ////    ID = 1,
            ////    TopicName = "Animal Rights and Conservation",
            ////    Status = true,
            ////    CreatedDate = DateTime.UtcNow
            ////});
            ////modelBuilder.Entity<Topic>().HasData(new Topic
            ////{
            ////    ID = 1,
            ////    TopicName = "Business and Economy",
            ////    Status = true,
            ////    CreatedDate = DateTime.UtcNow
            ////});
            ////modelBuilder.Entity<Topic>().HasData(new Topic
            ////{
            ////    ID = 1,
            ////    TopicName = "Child and Family Well-Being",
            ////    Status = true,
            ////    CreatedDate = DateTime.UtcNow
            ////});
            ////modelBuilder.Entity<Topic>().HasData(new Topic
            ////{
            ////    ID = 1,
            ////    TopicName = "Criminal Justice",
            ////    Status = true,
            ////    CreatedDate = DateTime.UtcNow
            ////});
        }
    }
}
