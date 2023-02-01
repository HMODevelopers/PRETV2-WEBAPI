namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUnionesUsuarioUnidadAdministrativa")]
    public partial class tblUnionesUsuarioUnidadAdministrativa
    {
        [Key]
        public int UnionUsuarioUnidadAdministrativaId { get; set; }

        public int UsuarioId { get; set; }

        public int UnidadAdministrativaId { get; set; }

        public bool Activo { get; set; }

        public virtual tblUnidadesAdministrativas tblUnidadesAdministrativas { get; set; }

        public virtual tblUsuarios tblUsuarios { get; set; }
    }
}
