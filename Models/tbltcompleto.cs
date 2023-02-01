namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbltcompleto")]
    public partial class tbltcompleto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbltcompleto()
        {
            tblinmueble = new HashSet<tblinmueble>();
        }

        [Key]
        [StringLength(10)]
        public string ct_clave { get; set; }

        [StringLength(1)]
        public string tco_tcompleto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblinmueble> tblinmueble { get; set; }
    }
}
