using System.ComponentModel.DataAnnotations;

namespace SalaryBook.Entities
{
    public class SalaryTypeAddViewModel
    {
        [MaxLength(5)]
        [Display(Name = "类型编号")]
        [Required(ErrorMessage = "编号必填")]
        public string TypeCode { get; set; }

        [MaxLength(50)]
        [Display(Name = "类型名称")]
        [Required(ErrorMessage = "类型名称必填")]
        public string TypeName { get; set; }

        [MaxLength(500)]
        [Display(Name = "类型说明")]
        public string TypeDec { get; set; }

        [MaxLength(500)]
        [Display(Name = "备注")]
        public string Remark { get; set; }
    }
}
