using MongoDB.Bson;

namespace MyPortfolio.Models
{
    public class Contact
    {
        public ObjectId Id { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public Contact()
        {

        }

        public Contact(string email, string name)
        {
            Email = email;
            Name = name;
        }
    }
}
