namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class talbergados
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int inm_id { get; set; }

        [StringLength(20)]
        public string alb_albergados { get; set; }

        public virtual tblinmueble tblinmueble { get; set; }
    }
}
