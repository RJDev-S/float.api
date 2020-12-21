using Float.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Float.Domain.Entities
{
    public class UserAccount : AuditableBaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string LoginType { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
