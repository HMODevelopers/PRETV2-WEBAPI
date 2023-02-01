namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbllocalidades
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mun_id { get; set; }

        [StringLength(3)]
        public string mun_inegiid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int loc_id { get; set; }

        [StringLength(4)]
        public string loc_inegiid { get; set; }

        [StringLength(45)]
        public string loc_nombre { get; set; }

        public int? pob_id { get; set; }

        public virtual tblmunicipios tblmunicipios { get; set; }
    }
}
