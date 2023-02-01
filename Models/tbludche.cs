namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbludche")]
    public partial class tbludche
    {
        [Key]
        [StringLength(4)]
        public string uds_udch { get; set; }

        [StringLength(30)]
        public string uds_nudch { get; set; }
    }
}
