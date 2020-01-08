using System;
using System.ComponentModel.DataAnnotations;

namespace SalaryBook.Entities
{
    /// <summary>
    /// 实体类型的基类，包含了大多数实体表该有的字段
    /// </summary>
    public class BaseEntity
    {
        public int Id { get; set; }

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
