using System.ComponentModel.DataAnnotations;

namespace SalaryBook.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="用户名是必填的")]
        [MaxLength(50,ErrorMessage ="长度不得超过50")]
        [Display(Name ="用户名")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "密码是必填的")]
        [MaxLength(50, ErrorMessage = "长度不得超过50")]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [Required(ErrorMessage = "请再次输入密码")]
        [MaxLength(50, ErrorMessage = "长度不得超过50")]
        [Display(Name = "确认密码")]
        public string ComfirmPassword { get; set; }

        //[Phone(ErrorMessage ="请输入正确的号码")]
        //[Display(Name = "手机号码")]
        //public string Mobile { get; set; }

        //[Required(ErrorMessage ="请输入您的出生年月")]
        //[Display(Name = "出生年月")]
        //public DateTime? BirthDay { get; set; }
    }
}
