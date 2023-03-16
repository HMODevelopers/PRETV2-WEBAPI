using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Models;
using System.Web.Http.Cors;

namespace PRETBV1_WEBAPP.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Authorize]
    [RoutePrefix("api/ReportesBrigadas")]
    public class ReporteBrigadasController : ApiController
    {
        private ModelContent db = new ModelContent();

        // GET: api/ReporteBrigadas
        public IQueryable<tblReporteBrigadas> GettblReporteBrigadas()
        {
            return db.tblReporteBrigadas;
        }

        [HttpGet]
        [Route("ObtenerReportes0")]
        public IHttpActionResult GetReportes0()
        {
            var reportes = db.tblReporteBrigadas.Include("tblUnionReporteBrigadaReporteConect")

                .Select(x => new
                {
                    x.ReporteGeneralId,
                    x.FolioReporteGeneral,
                    x.ct_id,
                    x.Concepto,
                    x.Diagnostico,
                    x.Seguimiento,
                    x.FechaCreacion,
                    x.FechaRespuesta,
                    x.FechaCierre,
                    x.EstatusId,
                    x.LevantoUsuarioId,
                    x.ResolvioUsuarioId,
                    x.AcompananteUsuarioId,
                    x.NumeroAulaMedios,
                    x.EquiposFuncionando,
                    x.EquiposConInternet,
                    x.Activo,
                    
                })
                .ToList();

            if (reportes == null)
            {
                return NotFound();
            }

            return Ok(reportes);
        }

        [HttpGet]
        [Route("ObtenerReportes")]
        public IHttpActionResult GetReportes()
        {
            var reportes = db.tblReporteBrigadas.Include("tblUnionReporteBrigadaReporteConect")
                                               
                .Select(x => new
                {
                    x.ReporteGeneralId,
                    x.FolioReporteGeneral,
                    x.ct_id,
                    x.Concepto,
                    x.Diagnostico,
                    x.Seguimiento,
                    x.FechaCreacion,
                    x.FechaRespuesta,
                    x.FechaCierre,
                    x.EstatusId,
                    x.LevantoUsuarioId,
                    x.ResolvioUsuarioId,
                    x.AcompananteUsuarioId,
                    x.NumeroAulaMedios,
                    x.EquiposFuncionando,
                    x.EquiposConInternet,
                    x.Activo,
                    x.tblUnionReporteBrigadaReporteConect
                })
                .ToList();

            if (reportes == null)
            {
                return NotFound();
            }

            return Ok(reportes);
        }


        [HttpGet]
        [Route("ObtenerReportes1")]
        public IHttpActionResult GetReportes1()
        {
            var reportes = db.tblReporteBrigadas
                
                .ToList();

            if (reportes == null)
            {
                return NotFound();
            }

            return Ok(reportes);
        }
        // GET: api/ReporteBrigadas/5
        [ResponseType(typeof(tblReporteBrigadas))]
        public IHttpActionResult GettblReporteBrigadas(int id)
        {
            tblReporteBrigadas tblReporteBrigadas = db.tblReporteBrigadas.Find(id);
            if (tblReporteBrigadas == null)
            {
                return NotFound();
            }

            return Ok(tblReporteBrigadas);
        }

        // PUT: api/ReporteBrigadas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblReporteBrigadas(int id, tblReporteBrigadas tblReporteBrigadas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblReporteBrigadas.ReporteGeneralId)
            {
                return BadRequest();
            }

            db.Entry(tblReporteBrigadas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblReporteBrigadasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ReporteBrigadas
        [ResponseType(typeof(tblReporteBrigadas))]
        public IHttpActionResult PosttblReporteBrigadas(tblReporteBrigadas tblReporteBrigadas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblReporteBrigadas.Add(tblReporteBrigadas);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tblReporteBrigadasExists(tblReporteBrigadas.ReporteGeneralId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tblReporteBrigadas.ReporteGeneralId }, tblReporteBrigadas);
        }

        // DELETE: api/ReporteBrigadas/5
        [ResponseType(typeof(tblReporteBrigadas))]
        public IHttpActionResult DeletetblReporteBrigadas(int id)
        {
            tblReporteBrigadas tblReporteBrigadas = db.tblReporteBrigadas.Find(id);
            if (tblReporteBrigadas == null)
            {
                return NotFound();
            }

            db.tblReporteBrigadas.Remove(tblReporteBrigadas);
            db.SaveChanges();

            return Ok(tblReporteBrigadas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblReporteBrigadasExists(int id)
        {
            return db.tblReporteBrigadas.Count(e => e.ReporteGeneralId == id) > 0;
        }
    }
}