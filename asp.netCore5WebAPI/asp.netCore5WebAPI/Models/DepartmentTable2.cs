using System;
using System.Collections.Generic;

#nullable disable

namespace asp.netCore5WebAPI.Models
{
    public partial class DepartmentTable2
    {
        public DepartmentTable2()
        {
            UserTable2s = new HashSet<UserTable2>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentYear { get; set; }

        public virtual ICollection<UserTable2> UserTable2s { get; set; }
    }
}
