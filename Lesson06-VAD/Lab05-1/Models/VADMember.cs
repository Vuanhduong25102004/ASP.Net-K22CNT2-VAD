using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab05_1.Models
{
    public class VADMember
    {
        [Required(ErrorMessage = "Hãy nhập mã số")]

        [DataType(DataType.Currency)]

        public int Id { get; set; }

        [Required(ErrorMessage = "Hãy nhập tên đăng nhập")]

        public string Username { get; set; }

        [Required(ErrorMessage = "Hãy nhập họ và tên")]

        public string FullName { get; set; }

        [Required(ErrorMessage = "Hãy nhập mật khẩu")]

        [DataType(DataType.Password)]

        public string Password { get; set; }

        [Required(ErrorMessage = "Hãy nhập tuổi")]

        [Range(18, 50, ErrorMessage = "Tuổi từ 18-50")]

        public int? Age { get; set; }

        [Required(ErrorMessage = "Hãy nhập email")]

        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Email phải đúng định dạng")]

        public string Email { get; set; }
    }
}