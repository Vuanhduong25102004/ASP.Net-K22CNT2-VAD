using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson08_VAD.Models
{
    /// <summary>
    /// tao ra cau truc bang book
    /// </summary>
    public class VadBook
    {
        [Key]
        public int VadBookId { get; set; }
        public string VadTitle  { get; set; }
        public string VadAuthor { get; set; }
        public int VadYear { get; set; }
        public string VadPublisher { get; set; }
        public string VadPicture { get; set; }
        public int VadCategoryId { get; set; }

        // thuoc tinh quan he
        public virtual VadCategory VadCategory { get; set; }
    }
}
