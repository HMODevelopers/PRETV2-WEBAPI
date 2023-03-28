using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.MiModelo
{
    public class ModReporteConect
    {
        public int ReporteConectId { get; set; }

        public string FolioConectividad { get; set; }

        public int? id_conect { get; set; }

        public int? ct_id { get; set; }

        public int? EstatusId { get; set; }

        public bool? FuncionaServidor { get; set; }

        public string ReporteProveedor { get; set; }

        public decimal? Subida { get; set; }

        public decimal? Bajada { get; set; }

        public string Concepto { get; set; }

        public string Diagnostico { get; set; }

        public string Seguimiento { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

    }
}
