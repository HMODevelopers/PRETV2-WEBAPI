namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbludch")]
    public partial class tbludch
    {
        [Key]
        public int udch_id { get; set; }

        [StringLength(10)]
        public string ct_clave { get; set; }

        [StringLength(4)]
        public string uds_udch { get; set; }
    }
}
