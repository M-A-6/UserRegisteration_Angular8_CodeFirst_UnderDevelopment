using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace APP.MODEL
{
    public class Department:BaseEntity
    {
        [Required]
        public string NameEn { get; set; }
        public string NameAr { get; set; }
    }
}
