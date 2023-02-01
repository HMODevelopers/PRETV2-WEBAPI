namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblEstatusReporte")]
    public partial class tblEstatusReporte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblEstatusReporte()
        {
            tblReporteBrigadas = new HashSet<tblReporteBrigadas>();
            tblReporteConect = new HashSet<tblReporteConect>();
            tblReporteDireccion = new HashSet<tblReporteDireccion>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EstatusId { get; set; }

        [StringLength(500)]
        public string NombreEstatus { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReporteBrigadas> tblReporteBrigadas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReporteConect> tblReporteConect { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReporteDireccion> tblReporteDireccion { get; set; }
    }
}
