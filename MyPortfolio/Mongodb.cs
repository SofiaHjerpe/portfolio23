using MongoDB.Bson;
using MongoDB.Driver;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPortfolio
{
    public class Mongodb
    {
        private IMongoDatabase GetDb()
        {
            MongoClient client = new MongoClient();
            var db = client.GetDatabase("PortfolioDataDB");
            return db;
        }

        public async Task SaveProject(Project project)
        {
            await GetDb().GetCollection<Project>("Projects")
                 .InsertOneAsync(project);
        }

        public async Task<List<Project>> GetAllProjects()
        {
            var projects = await GetDb().GetCollection<Project>("Projects")
                .Find(p => true)
                .ToListAsync();
            return projects;
        }

        public async Task<Project> GetProjectsById(string id)
        {
            ObjectId _id = new ObjectId(id);
            var project = await GetDb().GetCollection<Project>("Projects")
                .Find(p => p.Id == _id)
                .SingleOrDefaultAsync();
            return project;

        }


        public async Task DeleteProject(string id)
        {
            ObjectId _id = new ObjectId(id);
            await GetDb().GetCollection<Project>("Projects")
                .DeleteOneAsync(p => p.Id == _id);
        }

        public async Task SaveContact(Contact contact)
        {
            await GetDb().GetCollection<Contact>("Contacts")
                 .InsertOneAsync(contact);
        }

        public async Task<List<Contact>> GetAllContacts()
        {
            var contacts = await GetDb().GetCollection<Contact>("Contacts")
                .Find(c => true)
                .ToListAsync();
            return contacts;
        }
    }
}
