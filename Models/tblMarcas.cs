namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblMarcas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblMarcas()
        {
            tblInventarioAsignados = new HashSet<tblInventarioAsignados>();
            tblUnionesMarcaTipoEquipo = new HashSet<tblUnionesMarcaTipoEquipo>();
        }

        [Key]
        public int MarcaId { get; set; }

        [Required]
        [StringLength(150)]
        public string Marca { get; set; }

        public int Orden { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInventarioAsignados> tblInventarioAsignados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnionesMarcaTipoEquipo> tblUnionesMarcaTipoEquipo { get; set; }
    }
}
