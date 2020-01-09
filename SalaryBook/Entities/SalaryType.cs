using System.ComponentModel.DataAnnotations;

namespace SalaryBook.Entities
{
    public class SalaryType : BaseEntity
    {
        [MaxLength(5)]
        public string TypeCode { get; set; }
        [MaxLength(50)]
        public string TypeName { get; set; }
        [MaxLength(500)]
        public string TypeDec { get; set; }
    }
}
