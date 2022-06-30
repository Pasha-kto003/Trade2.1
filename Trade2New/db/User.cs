using System;
using System.Collections.Generic;

#nullable disable

namespace Trade2New.db
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserSurname { get; set; }
        public string UserName { get; set; }
        public string UserPatronymic { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public int UserRole { get; set; }

        public virtual Role UserRoleNavigation { get; set; }
    }
}
