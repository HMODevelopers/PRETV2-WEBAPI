namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblReporteDireccion")]
    public partial class tblReporteDireccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblReporteDireccion()
        {
            tblUnionReporteBrigadaReporteDireccion = new HashSet<tblUnionReporteBrigadaReporteDireccion>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReporteDireccionId { get; set; }

        [Required]
        [StringLength(50)]
        public string FolioDireccion { get; set; }

        public int? ct_id { get; set; }

        public DateTime? fecha_alta { get; set; }

        [StringLength(5000)]
        public string Concepto { get; set; }

        [StringLength(10)]
        public string Diagnostico { get; set; }

        [StringLength(5000)]
        public string Seguimiento { get; set; }

        [StringLength(50)]
        public string CorreoOficial { get; set; }

        public int? EstatusId { get; set; }

        public bool? Mantenimieto { get; set; }

        public bool? ExistenciaEquipo { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public virtual tblCentrosdetrabajo tblCentrosdetrabajo { get; set; }

        public virtual tblEstatusReporte tblEstatusReporte { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnionReporteBrigadaReporteDireccion> tblUnionReporteBrigadaReporteDireccion { get; set; }
    }
}
