namespace QLBH.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACCOUNT")]
    public partial class ACCOUNT
    {
        [Required]
        [StringLength(100)]
        public string DISPLAYNAME { get; set; }

        [Key]
        [StringLength(30)]
        public string USENAME { get; set; }

        [Required]
        [StringLength(30)]
        public string PASSWORD { get; set; }

        public int ROLE { get; set; }
    }
}
