namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblcodigo_postal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblcodigo_postal()
        {
            tblCentrosdetrabajo = new HashSet<tblCentrosdetrabajo>();
        }

        [Key]
        public int codcp_id { get; set; }

        [StringLength(5)]
        public string cod_cp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCentrosdetrabajo> tblCentrosdetrabajo { get; set; }
    }
}
