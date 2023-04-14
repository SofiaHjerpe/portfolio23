using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongodbDatabase
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
