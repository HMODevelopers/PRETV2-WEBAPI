namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblstipo")]
    public partial class tblstipo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long tip_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long stip_id { get; set; }

        [StringLength(160)]
        public string stip_nombre { get; set; }

        [Required]
        [StringLength(2)]
        public string stip_sostenimie { get; set; }
    }
}
