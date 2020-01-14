using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalaryBook.Entities
{
    public class ApplicationUser :IdentityUser
    {
        [MaxLength(50)]
        public string RealName { get; set; }

        [MaxLength(100)]
        public string Occupation { get; set; }

        public int? IsDelete { get; set; }

        [MaxLength(500)]
        public string Remark { get; set; }

        [MaxLength(50)]
        public string AddUser { get; set; }

        public DateTime? AddTime { get; set; }

        [MaxLength(50)]
        public string EditUser { get; set; }

        public DateTime? EditTime { get; set; }

    }
}
