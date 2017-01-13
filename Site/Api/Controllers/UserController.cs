using Api.Model;
using Api.Service;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class UserController : ApiController
    {
        private IUserService userService = new UserService();

        [HttpGet]
        [Route("user/{id:length(24)}")]
        public User Get(string id)
        {

            return userService.GetUser(new ObjectId(id));

        }
    }
}
