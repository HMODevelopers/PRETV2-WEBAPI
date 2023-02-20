using System;
using System.Collections.Generic;
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
        [Route("Roles/{id}")]
        public IHttpActionResult GetRoles(int id)
        {
            var roles = db.tblRoles.Where(x=>x.RolId== id).Select(x => new { x.RolId, x.Rol, x.Activo }).ToList();

            if (roles == null)
            {
                return NotFound();
            }

            return Ok(roles);
        }

        [HttpGet]
        [Route("ciclosEscolares")]
        public IHttpActionResult GetciclosEscolares()
        {
            var ciclos = db.tblCiclosEscolares.Select(x => new { x.CicloEscolarId, x.CicloEscolar, x.Activo }).ToList();

            if (ciclos == null)
            {
                return NotFound();
            }

            return Ok(ciclos);
        }

        [HttpGet]
        [Route("ciclosEscolares/{id}")]
        public IHttpActionResult GetCiclosEscolares(int id)
        {
            var ciclos = db.tblCiclosEscolares.Where(x => x.CicloEscolarId == id).Select(x => new { x.CicloEscolarId, x.CicloEscolar, x.Activo }).ToList();

            if (ciclos == null)
            {
                return NotFound();
            }

            return Ok(ciclos);
        }
        //-----------------------------------------------------------------------------------------------------
        [HttpGet]
        [Route("TipoFormacion")]
        public IHttpActionResult GetFormacion()
        {
            var formacion = db.tblTipoFormacion.Select(x => new { x.TipoFormacionId, x.NombreTipoFormacion, x.Activo }).ToList();

            if (formacion == null)
            {
                return NotFound();
            }

            return Ok(formacion);
        }

        [HttpGet]
        [Route("TipoFormacion/{id}")]
        public IHttpActionResult GetTipoFormacion(int id)
        {
            var formacion = db.tblTipoFormacion.Where(x => x.TipoFormacionId == id).Select(x => new { x.TipoFormacionId, x.NombreTipoFormacion, x.Activo }).ToList();

            if (formacion == null)
            {
                return NotFound();
            }

            return Ok(formacion);
        }
        //-----------------------------------------------------------------------------------------------------


        //-----------------------------------------------------------------------------------------------------
        [HttpGet]
        [Route("CatProveedores")]
        public IHttpActionResult GetPreveedores()
        {
            var proveedor = db.cat_proveedores.Select(x => new { x.id_proveedor, x.nombre_proveedor, x.activo }).ToList();

            if (proveedor == null)
            {
                return NotFound();
            }

            return Ok(proveedor);
        }

        [HttpGet]
        [Route("CatProveedores/{id}")]
        public IHttpActionResult GetPreveedores(int id)
        {
            var proveedor = db.cat_proveedores.Where(x => x.id_proveedor == id).Select(x => new { x.id_proveedor, x.nombre_proveedor, x.activo }).ToList();

            if (proveedor == null)
            {
                return NotFound();
            }

            return Ok(proveedor);
        }
        //-----------------------------------------------------------------------------------------------------

        //-----------------------------------------------------------------------------------------------------
        [HttpGet]
        [Route("CatAmbito")]
        public IHttpActionResult GetAmbito()
        {
            var ambito = db.cat_ambito.Select(x => new { x.id_ambito, x.nombre_ambito, x.activo }).ToList();

            if (ambito == null)
            {
                return NotFound();
            }

            return Ok(ambito);
        }

        [HttpGet]
        [Route("CatAmbito/{id}")]
        public IHttpActionResult GetAmbito(int id)
        {
            var ambito = db.cat_ambito.Where(x => x.id_ambito == id).Select(x => new { x.id_ambito, x.nombre_ambito, x.activo }).ToList();

            if (ambito == null)
            {
                return NotFound();
            }

            return Ok(ambito);
        }

        [HttpPost]
        [Route("AgregarCatAmbito")]
        public IHttpActionResult Postambito(cat_ambito cat_Ambito)
        //public void Postambito(cat_ambito cat_Ambito)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.cat_ambito.Add(cat_Ambito);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cat_Ambito.id_ambito, }, cat_Ambito);
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        [HttpGet]
        [Route("TipoConect")]
        public IHttpActionResult GetTipoConect()
        {
            var coneccion = db.cat_tipo_conect.Select(x => new { x.id_tipo_conect, x.nombre_tipo_conect, x.activo }).ToList();

            if (coneccion == null)
            {
                return NotFound();
            }

            return Ok(coneccion);
        }

        [HttpGet]
        [Route("TipoConect/{id}")]
        public IHttpActionResult GetTipoConect(int id)
        {
            var tipoc = db.cat_tipo_conect.Where(x => x.id_tipo_conect== id).Select(x => new { x.id_tipo_conect, x.nombre_tipo_conect, x.activo }).ToList();

            if (tipoc == null)
            {
                return NotFound();
            }

            return Ok(tipoc);
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        [HttpGet]
        [Route("CentrosTrabajo")]
        public IHttpActionResult GetCentrosTrabajos()
        {
            var centros = db.tblCentrosdetrabajo.Select(x => new { x.ct_id,x.ct_clave, x.ct_nombre,x.niv_id,x.sniv_id,x.ssniv_id,x.ct_calle,x.ct_entrecalle,x.ct_ycalle,
                x.loc_id,x.mun_id, x.ct_latitud,x.ct_longitud }).ToList();
            
            if (centros == null)
            {
                return NotFound();
            }

            return Ok(centros);
        }

        [HttpGet]
        [Route("CentrosTrabajo/{id}")]
        public IHttpActionResult GetCentrosTrabajos(int id)
        {
            var centros = db.tblCentrosdetrabajo.Where(x => x.ct_id == id).Select(x => new {  x.ct_id,x.ct_clave, x.ct_nombre,x.niv_id,x.sniv_id,x.ssniv_id,x.ct_calle,x.ct_entrecalle,x.ct_ycalle,
                x.loc_id,x.mun_id, x.ct_latitud,x.ct_longitud  }).ToList();

            if (centros == null)
            {
                return NotFound();
            }

            return Ok(centros);
        }
        //-----------------------------------------------------------------------------------------------------

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
