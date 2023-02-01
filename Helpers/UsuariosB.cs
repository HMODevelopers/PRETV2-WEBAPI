using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Helpers
{
    public class UsuariosB
    {
        public static ModelContent db = new ModelContent();



        public static string Create(tblUsuarios tblUser)
        {
            try
            {
                db.tblUsuarios.Attach(tblUser);
                db.Entry(tblUser).State = EntityState.Added;
                db.SaveChanges();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Update(tblUsuarios tblUser)
        {
            try
            {
                if (db != null)
                    db.Dispose();

                db = new ModelContent();
                db.tblUsuarios.Attach(tblUser);
                db.Entry(tblUser).State = EntityState.Modified;
                db.SaveChanges();
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public static tblUsuarios GetByCorreoElectronico(string sCorreoElectronico)
        {
            var vModel = db.tblUsuarios.Where(r => r.CorreoElectronico == sCorreoElectronico).FirstOrDefault();
            return vModel;
        }

        public tblUsuarios GetById(int iId)
        {
            var vModel = db.tblUsuarios.Where(r => r.UsuarioId == iId).FirstOrDefault();
            return vModel;
        }

        public static bool CheckIfExists(string sCorreoElectronico, int iId = 0)
        {
            var vModels = db.tblUsuarios.Where(r => r.CorreoElectronico == sCorreoElectronico && r.UsuarioId != iId).ToList();
            return vModels.Count > 0 ? true : false;
        }

        public object SearchByName(string sNombre)
        {
            var vModel = db.tblUsuarios
                .Where(r => r.Activo)
                .OrderBy(r => r.Nombre)
                //.Take(10)
                .Select(r => new
                {
                    name = r.Nombre
                });
            return vModel.Distinct();
        }

        public object SearchByFullName(string sFullName)
        {
            var vModel = db.tblUsuarios
                .Where(r => r.Activo)
                .OrderBy(r => r.Nombre)
                //.Take(10)
                .Select(r => new
                {
                    name = r.Nombre + " " + r.ApellidoPaterno + " " + r.ApellidoMaterno
                });
            return vModel.Distinct();
        }

        public object SearchByCorreoElectronico(string sUsuario)
        {
            var vModel = db.tblUsuarios
                .Where(r => r.Activo)
                .OrderBy(r => r.CorreoElectronico)
                //.Take(10)
                .Select(r => new
                {
                    name = r.CorreoElectronico
                });
            return vModel.Distinct();
        }

        public object SearchByPSurname(string sApellidoPaterno)
        {
            var vModel = db.tblUsuarios
                .Where(r => r.Activo)
                .OrderBy(r => r.ApellidoPaterno)
                //.Take(10)
                .Select(r => new
                {
                    name = r.ApellidoPaterno
                });
            return vModel.Distinct();
        }

        public object SearchByMSurname(string sApellidoMaterno)
        {
            var vModel = db.tblUsuarios
                .Where(r => r.Activo)
                .OrderBy(r => r.ApellidoMaterno)
                //.Take(10)
                .Select(r => new
                {
                    name = r.ApellidoMaterno
                });
            return vModel.Distinct();
        }

        public object SearchByEmail(string sCorreoElectronico)
        {
            var vModel = db.tblUsuarios
                .Where(r => r.Activo)
                .OrderBy(r => r.CorreoElectronico)
                //.Take(10)
                .Select(r => new
                {
                    name = r.CorreoElectronico
                });
            return vModel.Distinct();
        }





    }
}
