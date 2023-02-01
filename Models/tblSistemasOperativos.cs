namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblSistemasOperativos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSistemasOperativos()
        {
            tblInventarioAsignados = new HashSet<tblInventarioAsignados>();
        }

        [Key]
        public int SistemaOperativoId { get; set; }

        [Required]
        [StringLength(200)]
        public string SistemaOperativo { get; set; }

        public int Orden { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInventarioAsignados> tblInventarioAsignados { get; set; }
    }
}
