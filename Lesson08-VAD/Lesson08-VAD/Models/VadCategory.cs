using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lesson08_VAD.Models
{
    /// <summary>
    /// tao cau truc bang du lieu
    /// </summary>
    public class VadCategory
    {
        [Key]
        public int VadCategoryId { get; set; }
        public string VadCategoryName { get; set; }

        // thuoc tinh quan he
        public virtual ICollection<VadBook> VadBooks { get; set; }
    }
}