namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cat_ambito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cat_ambito()
        {
            tblconnections = new HashSet<tblconnections>();
        }

        [Key]
        public int id_ambito { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre_ambito { get; set; }

        public int activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblconnections> tblconnections { get; set; }
    }
}
