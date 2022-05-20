using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace ProjectEditor.Core.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public SecureString Password { get; set; }
    }
}
