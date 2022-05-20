using ProjectEditor.Common.Extensions;
using ProjectEditor.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ProjectEditor.Common.Services
{
    public class UserService : IUserService
    {

        private List<User> users = new List<User>()
       {
           new User
           {
               Id = Guid.NewGuid(),
               FirstName = "Test",
               LastName = "User",
               UserName = "Test",
               Password = new NetworkCredential("Test", "test").SecurePassword
           }
       };


        public async Task<User> Authenticate(string username, string password)
        {
            var user = users.SingleOrDefault(x => string.Compare(x.UserName, username, true) == 0
                                                  && new NetworkCredential(x.UserName, x.Password).Password == password);

            if (user == null)
            {
                return null;
            }

            return await Task.FromResult(user.WithoutPassword());
        }
    }
}