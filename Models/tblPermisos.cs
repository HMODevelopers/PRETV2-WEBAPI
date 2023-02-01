namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblPermisos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblPermisos()
        {
            tblPermisosRoles = new HashSet<tblPermisosRoles>();
        }

        [Key]
        public int PermisoId { get; set; }

        public int CatalogoBitacoraId { get; set; }

        [Required]
        [StringLength(100)]
        public string Controlador { get; set; }

        [Required]
        [StringLength(100)]
        public string Accion { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public int Orden { get; set; }

        public bool Activo { get; set; }

        public virtual tblCatalogosBitacora tblCatalogosBitacora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPermisosRoles> tblPermisosRoles { get; set; }
    }
}
