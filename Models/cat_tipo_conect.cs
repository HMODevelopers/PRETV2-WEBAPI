namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cat_tipo_conect
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cat_tipo_conect()
        {
            tblconnections = new HashSet<tblconnections>();
        }

        [Key]
        public int id_tipo_conect { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre_tipo_conect { get; set; }

        public int activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblconnections> tblconnections { get; set; }
    }
}
