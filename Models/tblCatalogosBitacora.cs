namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCatalogosBitacora")]
    public partial class tblCatalogosBitacora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCatalogosBitacora()
        {
            tblBitacora = new HashSet<tblBitacora>();
            tblPermisos = new HashSet<tblPermisos>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CatalogoBitacoraId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public int GrupoCatalagoId { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBitacora> tblBitacora { get; set; }

        public virtual tblGruposCatalagos tblGruposCatalagos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPermisos> tblPermisos { get; set; }
    }
}
