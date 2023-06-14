﻿namespace IdentityExample.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Guid RoleId { get; set; }
        public Role Role { get; set; }
    }
}
