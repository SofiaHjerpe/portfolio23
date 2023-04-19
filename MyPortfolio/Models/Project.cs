using MongoDB.Bson;

namespace MyPortfolio.Models
{
    public class Project
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public string Link { get; set; }
    }
}
