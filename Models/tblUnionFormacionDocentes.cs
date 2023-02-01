namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblUnionFormacionDocentes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUnionFormacionDocente { get; set; }

        public int FormacionId { get; set; }

        public int DocenteId { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaCreacion { get; set; }

        public virtual tblDocentes tblDocentes { get; set; }

        public virtual tblFormacion tblFormacion { get; set; }
    }
}
