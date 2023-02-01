namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDirectorio")]
    public partial class tblDirectorio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DirectorioId { get; set; }

        public int? ct_Id { get; set; }

        [StringLength(500)]
        public string NombreDirector { get; set; }

        public int? CelDirector { get; set; }

        [StringLength(500)]
        public string NombreContacto { get; set; }

        public int? CelContacto { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public virtual tblCentrosdetrabajo tblCentrosdetrabajo { get; set; }
    }
}
