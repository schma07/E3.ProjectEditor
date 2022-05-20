using ProjectEditor.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEditor.Common.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
    }
}
