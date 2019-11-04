using System;
using System.ComponentModel.DataAnnotations;

namespace APP.MODEL
{
    public class Employee : BaseEntity
    {
        [Required]
        public string NameEn { get; set; }
        public string NameAr { get; set; }
        public DateTime BirthDate { get; set; } 
        public int Department { get; set; }
    }
}
