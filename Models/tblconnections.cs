namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblconnections
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblconnections()
        {
            tblReporteConect = new HashSet<tblReporteConect>();
        }

        [Key]
        public int id_conect { get; set; }

        public int ct_id { get; set; }

        public int id_tipo_conect { get; set; }

        [StringLength(45)]
        public string ide_conect { get; set; }

        public int id_proveedor { get; set; }

        public int instalada { get; set; }

        public decimal? lat { get; set; }

        [Column("long")]
        public decimal? _long { get; set; }

        public int id_ambito { get; set; }

        public int activo { get; set; }

        public virtual cat_ambito cat_ambito { get; set; }

        public virtual cat_proveedores cat_proveedores { get; set; }

        public virtual cat_tipo_conect cat_tipo_conect { get; set; }

        public virtual tblCentrosdetrabajo tblCentrosdetrabajo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReporteConect> tblReporteConect { get; set; }
    }
}
