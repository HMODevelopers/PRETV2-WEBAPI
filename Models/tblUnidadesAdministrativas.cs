namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblUnidadesAdministrativas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUnidadesAdministrativas()
        {
            tblAsignacionesSolicitudes = new HashSet<tblAsignacionesSolicitudes>();
            tblFormacion = new HashSet<tblFormacion>();
            tblUnionesUsuarioUnidadAdministrativa = new HashSet<tblUnionesUsuarioUnidadAdministrativa>();
        }

        [Key]
        public int UnidadAdministrativaId { get; set; }

        [Required]
        [StringLength(200)]
        public string UnidadAdministrativa { get; set; }

        [Required]
        [StringLength(20)]
        public string Siglas { get; set; }

        public int Orden { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAsignacionesSolicitudes> tblAsignacionesSolicitudes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFormacion> tblFormacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnionesUsuarioUnidadAdministrativa> tblUnionesUsuarioUnidadAdministrativa { get; set; }
    }
}
