namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblssnivel_educativo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblssnivel_educativo()
        {
            tblCentrosdetrabajo = new HashSet<tblCentrosdetrabajo>();
        }

        [Key]
        public int ssniv_id { get; set; }

        [StringLength(255)]
        public string ssniv_nombre { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCentrosdetrabajo> tblCentrosdetrabajo { get; set; }
    }
}
