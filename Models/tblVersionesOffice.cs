namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblVersionesOffice")]
    public partial class tblVersionesOffice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblVersionesOffice()
        {
            tblInventarioAsignados = new HashSet<tblInventarioAsignados>();
        }

        [Key]
        public int VersionOfficeId { get; set; }

        [Required]
        [StringLength(200)]
        public string VersionOffice { get; set; }

        public int Orden { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInventarioAsignados> tblInventarioAsignados { get; set; }
    }
}
