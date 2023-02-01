namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblPermisosRoles
    {
        [Key]
        public int PermisoUsuarioId { get; set; }

        public int PermisoId { get; set; }

        public int RolId { get; set; }

        public bool Activo { get; set; }

        public virtual tblPermisos tblPermisos { get; set; }

        public virtual tblRoles tblRoles { get; set; }
    }
}
