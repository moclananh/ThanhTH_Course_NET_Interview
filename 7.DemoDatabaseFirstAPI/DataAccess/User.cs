using System;
using System.Collections.Generic;

#nullable disable

namespace _7.DemoDatabaseFirstAPI.DataAccess
{
    public partial class User
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
    }
}
