namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTiposSolicitud")]
    public partial class tblTiposSolicitud
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTiposSolicitud()
        {
            tblSolicitudes = new HashSet<tblSolicitudes>();
            tblSubtiposSolicitud = new HashSet<tblSubtiposSolicitud>();
        }

        [Key]
        public int TipoSolicitudId { get; set; }

        [Required]
        [StringLength(200)]
        public string TipoSolicitud { get; set; }

        public int Orden { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSolicitudes> tblSolicitudes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSubtiposSolicitud> tblSubtiposSolicitud { get; set; }
    }
}
