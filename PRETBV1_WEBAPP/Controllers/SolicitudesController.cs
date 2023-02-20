using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using Models;

namespace PRETBV1_WEBAPP.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Authorize]
    [RoutePrefix("api/solicitudes")]
    public class SolicitudesController : ApiController
    {
        
        private ModelContent db = new ModelContent();

        [HttpGet]
        [Route("Solicitudes")]
        public IHttpActionResult GetsSolicitudes()
        {
            var roles = db.tblSolicitudes.Select(x => new { x.SolicitudId,x.Folio, x.ct_id,x.Nombre,x.ApellidoPaterno,x.ApellidoMaterno, x.CorreoElectronico,x.Telefono,x.Extencion,x.TipoUsuarioId,x.TipoSolicitudId,x.SubtipoSolicitudId,x.Peticion,x.TipoModalidadId,x.Estatus,x.FechaCreacion,x.Activo, x.Oficio
 }).ToList();

            if (roles == null)
            {
                return NotFound();
            }

            return Ok(roles);
        }

        [HttpGet]
        [Route("Solicitudes/{id}")]
        public IHttpActionResult GetSolicitud(int id)
        {
            var formacion = db.tblSolicitudes.Where(x => x.SolicitudId == id).Select(x => new {
                x.SolicitudId,x.Folio, x.ct_id,x.Nombre,x.ApellidoPaterno,x.ApellidoMaterno, x.CorreoElectronico,x.Telefono,x.Extencion,x.TipoUsuarioId,x.TipoSolicitudId,x.SubtipoSolicitudId,x.Peticion,x.TipoModalidadId,x.Estatus,x.FechaCreacion,x.Activo, x.Oficio
            }).ToList();

            if (formacion == null)
            {
                return NotFound();
            }

            return Ok(formacion);
        }



        [HttpGet]
        [Route("SolicitudesF/{id}")]
        public IHttpActionResult GetSolicitudF(String id)
        {
            var formacion = db.tblSolicitudes.Where(x => x.Folio == id).Select(x => new {
                x.SolicitudId,
                x.Folio,
                x.ct_id,
                x.Nombre,
                x.ApellidoPaterno,
                x.ApellidoMaterno,
                x.CorreoElectronico,
                x.Telefono,
                x.Extencion,
                x.TipoUsuarioId,
                x.TipoSolicitudId,
                x.SubtipoSolicitudId,
                x.Peticion,
                x.TipoModalidadId,
                x.Estatus,
                x.FechaCreacion,
                x.Activo,
                x.Oficio
            }).ToList();

            if (formacion == null)
            {
                return NotFound();
            }

            return Ok(formacion);
        }

        // GET: api/Solicitudes

        [HttpPost]
        [Route("AgregarSolicitud")]
        public IHttpActionResult PostSolicitud(tblSolicitudes tblSolicitudesV)
        //public void Postambito(cat_ambito cat_Ambito)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblSolicitudes.Add(tblSolicitudesV);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblSolicitudesV.SolicitudId, }, tblSolicitudesV);
        }

        public IQueryable<tblSolicitudes> GettblSolicitudes()
        {
            return db.tblSolicitudes;
        }

        // GET: api/Solicitudes/5
        [ResponseType(typeof(tblSolicitudes))]
        public IHttpActionResult GettblSolicitudes(int id)
        {
            tblSolicitudes tblSolicitudes = db.tblSolicitudes.Find(id);
            if (tblSolicitudes == null)
            {
                return NotFound();
            }

            return Ok(tblSolicitudes);
        }

        // PUT: api/Solicitudes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblSolicitudes(int id, tblSolicitudes tblSolicitudes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblSolicitudes.SolicitudId)
            {
                return BadRequest();
            }

            db.Entry(tblSolicitudes).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblSolicitudesExists(id))
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

        // POST: api/Solicitudes
        [ResponseType(typeof(tblSolicitudes))]
        public IHttpActionResult PosttblSolicitudes(tblSolicitudes tblSolicitudes)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblSolicitudes.Add(tblSolicitudes);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblSolicitudes.SolicitudId }, tblSolicitudes);
        }

        // DELETE: api/Solicitudes/5
        [ResponseType(typeof(tblSolicitudes))]
        public IHttpActionResult DeletetblSolicitudes(int id)
        {
            tblSolicitudes tblSolicitudes = db.tblSolicitudes.Find(id);
            if (tblSolicitudes == null)
            {
                return NotFound();
            }

            db.tblSolicitudes.Remove(tblSolicitudes);
            db.SaveChanges();

            return Ok(tblSolicitudes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblSolicitudesExists(int id)
        {
            return db.tblSolicitudes.Count(e => e.SolicitudId == id) > 0;
        }
    }
}