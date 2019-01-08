using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SystemKnowledgeWebForms.Models
{
    public class DatabaseInitializer : DropCreateDatabaseIfModelChanges<UserContext>
    {
        protected override void Seed(UserContext context)
        {


            GetAreasOfKnowledge().ForEach(c => context.AreasOfKnowledge.Add(c));
            GetProducts().ForEach(p => context.Users.Add(p));


        }

        private static List<AreaOfKnowledge> GetAreasOfKnowledge()
        {
            var areasOfKnowledge = new List<AreaOfKnowledge> {
                new AreaOfKnowledge
                {
                    AreaOfKnowledgeID = 1,
                    AreaOfKnowledgeName = ".NET"
                },
                new AreaOfKnowledge
                {
                    AreaOfKnowledgeID = 2,
                    AreaOfKnowledgeName = "Java"
                },
                new AreaOfKnowledge
                {
                    AreaOfKnowledgeID = 3,
                    AreaOfKnowledgeName = "C++"
                },
                new AreaOfKnowledge
                {
                    AreaOfKnowledgeID = 4,
                    AreaOfKnowledgeName = "SQL"
                },
                new AreaOfKnowledge
                {
                    AreaOfKnowledgeID = 5,
                    AreaOfKnowledgeName = "JavaScript"
                },
            };

            return areasOfKnowledge;
        }

        private static List<User> GetProducts()
        {
            var users = new List<User> {
                new User
                {
                    UserID = 1,
                    FirstName = "Vira",
                    LastName = "Mazurkevych",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 1 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 2 },
                    //}
                    
               },
                new User
                {
                   UserID = 2,
                    FirstName = "Oksana",
                    LastName = "Lytvyn",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 3 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 4 },
                    //}
               },
                new User
                {
                   UserID = 3,
                    FirstName = "Roman",
                    LastName = "Antonov",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 5 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 1 },
                    //}
                },
                new User
                {
                   UserID = 4,
                    FirstName = "Mariia",
                    LastName = "Vasylenko",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 2 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 3 },
                    //}
                },
                new User
                {
                   UserID = 5,
                    FirstName = "Nastya",
                    LastName = "Petrenko",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 4 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 5 },
                    //}
                },
                new User
                {
                   UserID = 6,
                    FirstName = "Oleksandra",
                    LastName = "Kuzmenko",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 1 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 2 },
                    //}
                },
                new User
                {
                    UserID = 7,
                    FirstName = "Oleksandr",
                    LastName = "Som",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 3 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 4 },
                    //}
                },
                new User
                {
                   UserID = 8,
                    FirstName = "Lena",
                    LastName = "Ivanenko",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 5 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 1 },
                    //}
                },
                new User
                {
                   UserID = 9,
                    FirstName = "Sergiy",
                    LastName = "Axankov",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 2 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 3 },
                    //}
                },
                new User
                {
                   UserID = 10,
                    FirstName = "Nadiia",
                    LastName = "Petrenko",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 4 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 5 },
                    //}
                },
                new User
                {
                   UserID = 11,
                    FirstName = "Olya",
                    LastName = "Phomenko",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 1 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 2 },
                    //}
                },
                new User
                {
                   UserID = 12,
                    FirstName = "Dmytro",
                    LastName = "Kozachenko",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 3 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 4 },
                    //}
                },
                new User
                {
                    UserID = 13,
                    FirstName = "Petro",
                    LastName = "Phomin",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 5 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 1 },
                    //}
                },
                new User
                {
                  UserID = 14,
                    FirstName = "Ivan",
                    LastName = "Ivanenko",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 2 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 3 },
                    //}
                },
                new User
                {
                   UserID = 15,
                    FirstName = "Konstantyn",
                    LastName = "Molodenkov",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 4 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 5 },
                    //}
                },
                new User
                {
                  UserID = 16,
                    FirstName = "Julia",
                    LastName = "Karpenko",
                    ImagePath="carconvert.png"
                    //,
                    //AreasOfKnowledges = new List<AreaOfKnowledge>()
                    //{
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 1 },
                    //    new AreaOfKnowledge { AreaOfKnowledgeID = 2 },
                    //}
                }
            };

            return users;
        }
    }
}