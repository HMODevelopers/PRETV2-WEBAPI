namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblUnionReportesBrigadasActividades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UnionReportesActividadesId { get; set; }

        public int? ReporteGeneralId { get; set; }

        public int? ActividadId { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public virtual tblActividadesReporte tblActividadesReporte { get; set; }

        public virtual tblReporteBrigadas tblReporteBrigadas { get; set; }
    }
}
