namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUnionesMarcaTipoEquipo")]
    public partial class tblUnionesMarcaTipoEquipo
    {
        [Key]
        public int UnionMarcaTipoEquipoId { get; set; }

        public int MarcaId { get; set; }

        public int TipoEquipoId { get; set; }

        public bool Activo { get; set; }

        public virtual tblMarcas tblMarcas { get; set; }

        public virtual tblTiposEquipo tblTiposEquipo { get; set; }
    }
}
