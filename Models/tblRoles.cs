namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblRoles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRoles()
        {
            tblPermisosRoles = new HashSet<tblPermisosRoles>();
            tblUsuarios = new HashSet<tblUsuarios>();
        }

        [Key]
        public int RolId { get; set; }

        [Required]
        [StringLength(50)]
        public string Rol { get; set; }

        public bool PermisosIlimitados { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPermisosRoles> tblPermisosRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUsuarios> tblUsuarios { get; set; }
    }
}
