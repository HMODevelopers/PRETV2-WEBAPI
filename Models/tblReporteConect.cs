namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblReporteConect")]
    public partial class tblReporteConect
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblReporteConect()
        {
            tblUnionReporteBrigadaReporteConect = new HashSet<tblUnionReporteBrigadaReporteConect>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReporteConectId { get; set; }

        [Required]
        [StringLength(50)]
        public string FolioConectividad { get; set; }

        public int? id_conect { get; set; }

        public int? ct_id { get; set; }

        public int? EstatusId { get; set; }

        public bool? FuncionaServidor { get; set; }

        [StringLength(50)]
        public string ReporteProveedor { get; set; }

        public decimal? Subida { get; set; }

        public decimal? Bajada { get; set; }

        [StringLength(5000)]
        public string Concepto { get; set; }

        [StringLength(10)]
        public string Diagnostico { get; set; }

        [StringLength(10)]
        public string Seguimiento { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public virtual tblCentrosdetrabajo tblCentrosdetrabajo { get; set; }

        public virtual tblconnections tblconnections { get; set; }

        public virtual tblEstatusReporte tblEstatusReporte { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnionReporteBrigadaReporteConect> tblUnionReporteBrigadaReporteConect { get; set; }
    }
}
