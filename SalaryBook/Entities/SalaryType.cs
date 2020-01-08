using System.ComponentModel.DataAnnotations;

namespace SalaryBook.Entities
{
    public class SalaryType : BaseEntity
    {
        public int TypeCode { get; set; }
        [MaxLength(50)]
        public string TypeName { get; set; }
        [MaxLength(500)]
        public string TypeDec { get; set; }
    }
}
