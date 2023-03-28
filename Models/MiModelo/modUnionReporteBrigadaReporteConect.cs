using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.MiModelo
{
    public class modUnionReporteBrigadaReporteConect
    {
        public int UnionReportesActividadesId { get; set; }

        public int? ReporteGeneralId { get; set; }

        public int? ReporteConectId { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }
    }
}
