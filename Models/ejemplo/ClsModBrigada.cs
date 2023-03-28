using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ejemplo
{
    public class ClsModBrigada
    {
        
// FolioReporteGeneral
//ct_id
//Concepto
//Diagnostico
//Seguimiento
//FechaCreacion
//FechaRespuesta
//FechaCierre
//EstatusId
//LevantoUsuarioId
//ResolvioUsuarioId
//AcompananteUsuarioId
//NumeroAulaMedios
//EquiposFuncionando
//EquiposConInternet
//Activo

        public int ReporteGeneralId { get; set; }
        public modUnionReporteBrigadaReporteConect tblUnionReporteBrigadaReporteConect { get; set; }
       
    }
}
