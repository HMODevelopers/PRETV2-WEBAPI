namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUnionReporteBrigadaReporteDireccion")]
    public partial class tblUnionReporteBrigadaReporteDireccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UnionReportesActividadesId { get; set; }

        public int? ReporteGeneralId { get; set; }

        public int? ReporteDireccionId { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public virtual tblReporteBrigadas tblReporteBrigadas { get; set; }

        public virtual tblReporteDireccion tblReporteDireccion { get; set; }
    }
}
