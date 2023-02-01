namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblReporteBrigadas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblReporteBrigadas()
        {
            tblUnionReporteBrigadaReporteConect = new HashSet<tblUnionReporteBrigadaReporteConect>();
            tblUnionReporteBrigadaReporteDireccion = new HashSet<tblUnionReporteBrigadaReporteDireccion>();
            tblUnionReportesBrigadasActividades = new HashSet<tblUnionReportesBrigadasActividades>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReporteGeneralId { get; set; }

        [StringLength(50)]
        public string FolioReporteGeneral { get; set; }

        public int ct_id { get; set; }

        [StringLength(500)]
        public string Concepto { get; set; }

        [StringLength(10)]
        public string Diagnostico { get; set; }

        [StringLength(5000)]
        public string Seguimiento { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public DateTime? FechaRespuesta { get; set; }

        public DateTime? FechaCierre { get; set; }

        public int? EstatusId { get; set; }

        public int? LevantoUsuarioId { get; set; }

        public int? ResolvioUsuarioId { get; set; }

        public int? AcompananteUsuarioId { get; set; }

        public int? NumeroAulaMedios { get; set; }

        public int? EquiposFuncionando { get; set; }

        public int? EquiposConInternet { get; set; }

        public int? Activo { get; set; }

        public virtual tblCentrosdetrabajo tblCentrosdetrabajo { get; set; }

        public virtual tblEstatusReporte tblEstatusReporte { get; set; }

        public virtual tblUsuarios tblUsuarios { get; set; }

        public virtual tblUsuarios tblUsuarios1 { get; set; }

        public virtual tblUsuarios tblUsuarios2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnionReporteBrigadaReporteConect> tblUnionReporteBrigadaReporteConect { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnionReporteBrigadaReporteDireccion> tblUnionReporteBrigadaReporteDireccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnionReportesBrigadasActividades> tblUnionReportesBrigadasActividades { get; set; }
    }
}
