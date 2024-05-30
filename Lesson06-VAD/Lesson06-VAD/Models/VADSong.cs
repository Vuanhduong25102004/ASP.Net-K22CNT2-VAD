using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Lesson06_VAD.Models
{
    public class VADSong
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "VAD: Hãy nhập tiêu đề bài hát !")]
        [DisplayName("Tiêu đề")]
        public string VADTitle { get; set; }

        [Required(ErrorMessage = "VAD: Hãy nhập tác giả bài hát !")]
        [DisplayName("Nghệ sĩ")]
        public string VADAuthor { get; set; }

        [Required(ErrorMessage = "VAD: Hãy nhập nghệ sĩ !")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "VAD: Độ dài trong khoảng [2-50]!")]
        [DisplayName("Tác giả")]

        public string VADArtist { get; set; }

        [Required(ErrorMessage = "VAD: Hãy nhập năm xuất bản")]
        [RegularExpression(@"[0-9]{4}", ErrorMessage = "VAD: Hãy nhập năm xuất bản là 4 ký tự số !")]
        [Range(1900, 2020, ErrorMessage = "VAD: Hãy nhập năm trong khoảng [1900-2020]")]
        [DisplayName("Năm ra mắt")]
        public int VADYearRelease { get; set; }
    }
}