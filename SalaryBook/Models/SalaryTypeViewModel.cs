using System;
using System.ComponentModel.DataAnnotations;

namespace SalaryBook.Models
{
    public class SalaryTypeViewModel
    {
        [Display(Name ="ID")]
        public int Id { get; set; }

        [Display(Name = "类型编号" )]
        public string TypeCode { get; set; }

        [Display(Name = "类型名称")]
        public string TypeName { get; set; }

        [Display(Name = "类型说明")]
        public string TypeDec { get; set; }

        [Display(Name = "添加人")]
        public string AddUser { get; set; }

        [Display(Name = "添加时间")]
        public DateTime? AddTime { get; set; }

        [Display(Name = "修改人")]
        public string EditUser { get; set; }

        [Display(Name = "修改时间")]
        public DateTime? EditTime { get; set; }
    }
}
