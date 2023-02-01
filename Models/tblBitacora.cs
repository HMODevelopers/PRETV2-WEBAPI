namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBitacora")]
    public partial class tblBitacora
    {
        [Key]
        public int BitacoraId { get; set; }

        public int? CatalogoBitacoraId { get; set; }

        [StringLength(50)]
        public string Campo { get; set; }

        public string ValorAnterior { get; set; }

        public string ValorActual { get; set; }

        public DateTime Fecha { get; set; }

        public int UsuarioId { get; set; }

        public string Descripcion { get; set; }

        public int? RegistroId { get; set; }

        public virtual tblCatalogosBitacora tblCatalogosBitacora { get; set; }
    }
}
