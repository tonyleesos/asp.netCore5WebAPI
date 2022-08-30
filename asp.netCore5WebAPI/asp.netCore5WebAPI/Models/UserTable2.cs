using System;
using System.Collections.Generic;

#nullable disable

namespace asp.netCore5WebAPI.Models
{
    public partial class UserTable2
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserSex { get; set; }
        public DateTime? UserBirthDay { get; set; }
        public string UserMobilePhone { get; set; }
        public bool UserApproved { get; set; }
        public int? DepartmentId { get; set; }

        public virtual DepartmentTable2 Department { get; set; }
    }
}
