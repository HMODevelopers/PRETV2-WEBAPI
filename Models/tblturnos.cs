namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblturnos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblturnos()
        {
            tbldetalle_ct_turno = new HashSet<tbldetalle_ct_turno>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long tur_id { get; set; }

        [StringLength(45)]
        public string tur_nombre { get; set; }

        [StringLength(3)]
        public string tur_desc { get; set; }

        [StringLength(3)]
        public string tur_abr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbldetalle_ct_turno> tbldetalle_ct_turno { get; set; }
    }
}
