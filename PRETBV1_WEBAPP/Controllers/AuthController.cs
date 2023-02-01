using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Helpers;
using Models;
using REDIN1.Security;

namespace PRETBV1_WEBAPP.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AuthController : ApiController
    {

        private ModelContent db = new ModelContent();
        int action;
        private tblUsuarios u;


        [HttpPost]
        public IHttpActionResult Login(tblUsuarios user)
        {
            tblUsuarios tblNewUser = UsuariosB.GetByCorreoElectronico(user.CorreoElectronico);
            bool bLoggedCorrectly = false;

           
            if (tblNewUser == null)
            {

                return BadRequest("Usuario no existe");
            }
            else if (tblNewUser.Contrasena != SecurityPassword.Encrypt( user.Contrasena))
            {

                return BadRequest("Contraseña incorrectos.");
            }
            else if (!tblNewUser.Activo)
            {

                return BadRequest("Usuario inactivo");
            }
            else if (tblNewUser.Contrasena == SecurityPassword.Encrypt(user.Contrasena))
            {
                bLoggedCorrectly = true;
                user = tblNewUser;
            }
            if (bLoggedCorrectly)
            {
                u = db.tblUsuarios.Where(x => x.CorreoElectronico == user.CorreoElectronico).SingleOrDefault();
                var token = TokenGenerator.GenerateTokenJwt(u);

                var us = new
                {
                    id =  u.UsuarioId,
                    username = u.CorreoElectronico,
                    password =  u.Contrasena,
                    firstName =  u.Nombre,
                    lastName =  u.ApellidoPaterno +" "+ u.ApellidoMaterno,
                    token =  token
                };

                return Ok(us);
            }
            else
            {
                return BadRequest("Usuario y/o contraseña incorrectos.");
            }

            


        }
    }
}
