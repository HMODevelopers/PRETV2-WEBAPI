using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Models;

namespace PRETBV1_WEBAPP.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Authorize]
    [RoutePrefix("api/Catalogos")]
    public class CatalogosController : ApiController
    {
        private ModelContent db = new ModelContent();


        [HttpGet]
        [Route("Roles")]
        public IHttpActionResult GetRoles()
        {
            var roles = db.tblRoles.Select(x => new { x.RolId, x.Rol,x.Activo}).ToList();

            if ( roles == null)
            {
                return NotFound();
            }

            return Ok(roles);
        }

      

        [HttpGet]
        [Route("Rol")]
        public IHttpActionResult GetRol(int id)
        {
            var roles = db.tblRoles.Where(x=>x.RolId== id).Select(x => new { x.RolId, x.Rol, x.Activo }).ToList();

            if (roles == null)
            {
                return NotFound();
            }

            return Ok(roles);
        }



        [HttpGet]
        [Route("TipoModalidad")]
        public IHttpActionResult GetTipoModalidad()
        {
            var tipomodalidad = db.tblTipoModalidades.Select(x => new { x.TipoModalidadId, x.TipoModalidad, x.Activo }).ToList();

            if (tipomodalidad == null)
            {
                return NotFound();
            }

            return Ok(tipomodalidad);
        }

        [HttpGet]
        [Route("TipoUsuario")]
        public IHttpActionResult GetTipoUsuario()
        {
            var tipousuario = db.tblTipoUsuarios.Select(x => new { x.TipoUsuarioId, x.TipoUsuario, x.Activo }).ToList();

            if (tipousuario == null)
            {
                return NotFound();
            }

            return Ok(tipousuario);
        }

        [HttpGet]
        [Route("TipoSolicitud")]
        public IHttpActionResult GetTipoSolicitud()
        {
            var tiposolicitud = db.tblTiposSolicitud.Select(x => new { x.TipoSolicitudId, x.TipoSolicitud, x.Activo }).ToList();

            if (tiposolicitud == null)
            {
                return NotFound();
            }

            return Ok(tiposolicitud);
        }

        [HttpGet]
        [Route("SubTipoSolicitud")]
        public IHttpActionResult GetSubTipoSolicitud()
        {
            var subtiposolicitud = db.tblSubtiposSolicitud.Select(x => new { x.SubtipoSolicitudId, x.SubtipoSolicitud, x.Activo }).ToList();

            if (subtiposolicitud == null)
            {
                return NotFound();
            }

            return Ok(subtiposolicitud);
        }

        [HttpGet]
        [Route("UnidadesAdministrativas")]
        public IHttpActionResult GetUnidadesAdministrativas()
        {
            var UnidadesAdministrativas = db.tblUnidadesAdministrativas.Select(x => new { x.UnidadAdministrativaId, x.UnidadAdministrativa,x.Siglas, x.Activo }).ToList();

            if (UnidadesAdministrativas == null)
            {
                return NotFound();
            }

            return Ok(UnidadesAdministrativas);
        }
    }
}
