namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTipoFormacion")]
    public partial class tblTipoFormacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TipoFormacionId { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreTipoFormacion { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaCreacion { get; set; }

        public virtual tblFormacion tblFormacion { get; set; }
    }
}
