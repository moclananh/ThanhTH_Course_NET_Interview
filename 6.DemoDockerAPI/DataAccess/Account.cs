using System;
using System.Collections.Generic;

#nullable disable

namespace _6.DemoDockerAPI.DataAccess
{
    public partial class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsCus { get; set; }
        public bool? IsAdmin { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
