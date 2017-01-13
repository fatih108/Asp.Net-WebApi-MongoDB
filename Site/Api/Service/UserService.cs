using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Api.Model;
using MongoDB.Bson;
using Api.Data;
using MongoDB.Driver;

namespace Api.Service
{
    public class UserService : IUserService
    {
        private ApiDbContext db = new ApiDbContext();
        public User GetUser(ObjectId id)
        {
        
            User user = db.Database.GetCollection<User>("User").Find(x => x.Id == id).SingleOrDefault();

            return user;

        }
    }
}