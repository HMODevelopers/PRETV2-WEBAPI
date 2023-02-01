namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblmunicipios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblmunicipios()
        {
            tblCentrosdetrabajo = new HashSet<tblCentrosdetrabajo>();
            tbllocalidades = new HashSet<tbllocalidades>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mun_id { get; set; }

        [Required]
        [StringLength(3)]
        public string mun_inegiid { get; set; }

        [StringLength(45)]
        public string mun_nombre { get; set; }

        [Required]
        [StringLength(2)]
        public string mun_entinegiid { get; set; }

        [StringLength(2)]
        public string zest_zona { get; set; }

        public long? clave { get; set; }

        [StringLength(4)]
        public string udch { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCentrosdetrabajo> tblCentrosdetrabajo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbllocalidades> tbllocalidades { get; set; }
    }
}
