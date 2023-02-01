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
    public class UsuariosController : ApiController
    {
        private ModelContent db = new ModelContent();

        // GET: api/Usuarios
        public IHttpActionResult GettblUsuarios()
        {
            var usuarios = db.tblUsuarios.Select(x => new { x.UsuarioId, x.Nombre, x.ApellidoPaterno, x.ApellidoMaterno, x.CorreoElectronico , x.Activo, x.Celular, x.tblRoles.Rol}).ToList();
            if (usuarios == null)
            {
                return StatusCode(HttpStatusCode.NotFound);
            }

            return Ok(usuarios);
        }

        // GET: api/Usuarios/5
        [ResponseType(typeof(tblUsuarios))]
        public IHttpActionResult GettblUsuarios(int id)
        {
            var  tblUsuarios = db.tblUsuarios.Where(x => x.UsuarioId == id).Select(x => new { x.UsuarioId, x.Nombre, x.ApellidoPaterno, x.ApellidoMaterno, x.CorreoElectronico, x.Activo, x.Celular, x.tblRoles.Rol }).FirstOrDefault();
            if (tblUsuarios == null)
            {
                return NotFound();
            }

            return Ok(tblUsuarios);
        }

        // PUT: api/Usuarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblUsuarios(int id, tblUsuarios tblUsuarios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblUsuarios.UsuarioId)
            {
                return BadRequest();
            }

            db.Entry(tblUsuarios).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblUsuariosExists(id))
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

        // POST: api/Usuarios
        [ResponseType(typeof(tblUsuarios))]
        public IHttpActionResult PosttblUsuarios(tblUsuarios tblUsuarios)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblUsuarios.Add(tblUsuarios);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblUsuarios.UsuarioId }, tblUsuarios);
        }

        // DELETE: api/Usuarios/5
        [ResponseType(typeof(tblUsuarios))]
        public IHttpActionResult DeletetblUsuarios(int id)
        {
            tblUsuarios tblUsuarios = db.tblUsuarios.Find(id);
            if (tblUsuarios == null)
            {
                return NotFound();
            }

            db.tblUsuarios.Remove(tblUsuarios);
            db.SaveChanges();

            return Ok(tblUsuarios);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblUsuariosExists(int id)
        {
            return db.tblUsuarios.Count(e => e.UsuarioId == id) > 0;
        }
    }
}