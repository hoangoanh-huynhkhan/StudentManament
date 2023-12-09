namespace DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employer")]
    public partial class Employer
    {
        public int EmployerID { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployerName { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployerUserName { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployerPassword { get; set; }

        public byte EmployerRole { get; set; }

        public byte EmployerDelete { get; set; }
    }
}
