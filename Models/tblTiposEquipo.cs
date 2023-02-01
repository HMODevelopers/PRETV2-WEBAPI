namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTiposEquipo")]
    public partial class tblTiposEquipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTiposEquipo()
        {
            tblInventarioAsignados = new HashSet<tblInventarioAsignados>();
            tblUnionesMarcaTipoEquipo = new HashSet<tblUnionesMarcaTipoEquipo>();
        }

        [Key]
        public int TipoEquipoId { get; set; }

        [Required]
        [StringLength(150)]
        public string TipoEquipo { get; set; }

        public int Orden { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInventarioAsignados> tblInventarioAsignados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnionesMarcaTipoEquipo> tblUnionesMarcaTipoEquipo { get; set; }
    }
}
