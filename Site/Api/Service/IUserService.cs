using Api.Model;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Service
{
    interface IUserService
    {
        User GetUser(ObjectId id);

    }
}
