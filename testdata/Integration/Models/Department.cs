using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace testdata.Integration.Models
{
    [Table("UserDepartment")]
    public class Department
    {
        public int ID { get; set; }

        public string DepartmentName { get; set; }

        [Column("DateOfJoining")]
        public DateTime? DOB { get; set; }
    }
}
