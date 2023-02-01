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
    public class CentrosdetrabajoController : ApiController
    {
        private ModelContent db = new ModelContent();

        // GET: api/Centrosdetrabajo
        public IHttpActionResult GettblCentrosdetrabajo()
        {
            var escuelas = db.tblCentrosdetrabajo.Select( x => new { x.ct_id, x.ct_clave, x.ct_nombre, x.est_id}).ToList();
            
            if (escuelas == null)
            {
                return NotFound();
            }

            return Ok(escuelas);
        }

        // GET: api/Centrosdetrabajo/5
        [ResponseType(typeof(tblCentrosdetrabajo))]
        public IHttpActionResult GettblCentrosdetrabajo(int id)
        {
            var escuela = db.tblCentrosdetrabajo.Where(x => x.ct_id == id).Select(x => new { x.ct_id, x.ct_clave, x.ct_nombre, x.est_id }).FirstOrDefault();
            if (escuela == null)
            {
                return NotFound();
            }

            return Ok(escuela);
        }

        // PUT: api/Centrosdetrabajo/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblCentrosdetrabajo(int id, tblCentrosdetrabajo tblCentrosdetrabajo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblCentrosdetrabajo.ct_id)
            {
                return BadRequest();
            }

            db.Entry(tblCentrosdetrabajo).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblCentrosdetrabajoExists(id))
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

        // POST: api/Centrosdetrabajo
        [ResponseType(typeof(tblCentrosdetrabajo))]
        public IHttpActionResult PosttblCentrosdetrabajo(tblCentrosdetrabajo tblCentrosdetrabajo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblCentrosdetrabajo.Add(tblCentrosdetrabajo);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (tblCentrosdetrabajoExists(tblCentrosdetrabajo.ct_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = tblCentrosdetrabajo.ct_id }, tblCentrosdetrabajo);
        }

        // DELETE: api/Centrosdetrabajo/5
        [ResponseType(typeof(tblCentrosdetrabajo))]
        public IHttpActionResult DeletetblCentrosdetrabajo(int id)
        {
            tblCentrosdetrabajo tblCentrosdetrabajo = db.tblCentrosdetrabajo.Find(id);
            if (tblCentrosdetrabajo == null)
            {
                return NotFound();
            }

            db.tblCentrosdetrabajo.Remove(tblCentrosdetrabajo);
            db.SaveChanges();

            return Ok(tblCentrosdetrabajo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblCentrosdetrabajoExists(int id)
        {
            return db.tblCentrosdetrabajo.Count(e => e.ct_id == id) > 0;
        }
    }
}