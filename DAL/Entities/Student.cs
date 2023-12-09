namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [StringLength(50)]
        public string StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentName { get; set; }

        public byte StudentGender { get; set; }

        [Column(TypeName = "date")]
        public DateTime StudentBirthDay { get; set; }

        public double StudentAgv { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentFaculty { get; set; }

        [Required]
        [StringLength(50)]
        public string StudentMajor { get; set; }

        [MaxLength(50)]
        public byte[] StudentAvatar { get; set; }

        public byte StudentDelete { get; set; }

        public virtual Faculty Faculty { get; set; }

        public virtual Major Major { get; set; }
    }
}
