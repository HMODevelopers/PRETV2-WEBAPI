namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSubtiposSolicitud")]
    public partial class tblSubtiposSolicitud
    {
        [Key]
        public int SubtipoSolicitudId { get; set; }

        [Required]
        [StringLength(200)]
        public string SubtipoSolicitud { get; set; }

        public int TipoSolicitudId { get; set; }

        public int Orden { get; set; }

        public bool Activo { get; set; }

        public virtual tblTiposSolicitud tblTiposSolicitud { get; set; }
    }
}
