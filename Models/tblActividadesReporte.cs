namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblActividadesReporte")]
    public partial class tblActividadesReporte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblActividadesReporte()
        {
            tblUnionReportesBrigadasActividades = new HashSet<tblUnionReportesBrigadasActividades>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ActividadId { get; set; }

        [StringLength(50)]
        public string NombreActividad { get; set; }

        public bool? Activo { get; set; }

        public DateTime? FechaCreacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnionReportesBrigadasActividades> tblUnionReportesBrigadasActividades { get; set; }
    }
}
