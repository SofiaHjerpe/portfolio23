using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongodbDatabase
{
        public class Contact
        {
            public ObjectId Id { get; set; }

            public string Email { get; set; }

            public string Name { get; set; }

        public Contact() {
        
        }

        public Contact(string email, string name)
        {
            Email = email;  
            Name = name;    
        }

        }

    }
