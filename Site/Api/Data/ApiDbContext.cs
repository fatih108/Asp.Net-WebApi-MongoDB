using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Api.Data
{
    public class ApiDbContext
    {
        public IMongoDatabase Database
        {
            get
            {
                var client = new MongoClient(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);

                var database = client.GetDatabase("Site");

                return database;
            }
        }
    }
}