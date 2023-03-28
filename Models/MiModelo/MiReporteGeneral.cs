using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.MiModelo
{
    public class MiReporteGeneral
    {
        public int ReporteGeneralId { get; set; }
        public string FolioReporteGeneral { get; set; }
        public int ct_id { get; set; }
        public string Concepto { get; set; }
        public string Diagnostico { get; set; }
        public string Seguimiento { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public modUnionReporteBrigadaReporteConect tblUnionReporteBrigadaReporteConect { get; set; }
    }
}
