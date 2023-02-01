namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblUsuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUsuarios()
        {
            tblReporteBrigadas = new HashSet<tblReporteBrigadas>();
            tblReporteBrigadas1 = new HashSet<tblReporteBrigadas>();
            tblReporteBrigadas2 = new HashSet<tblReporteBrigadas>();
            tblUnionesUsuarioUnidadAdministrativa = new HashSet<tblUnionesUsuarioUnidadAdministrativa>();
        }

        [Key]
        public int UsuarioId { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string ApellidoPaterno { get; set; }

        [StringLength(200)]
        public string ApellidoMaterno { get; set; }

        public int RolId { get; set; }

        [Required]
        public string Contrasena { get; set; }

        [StringLength(100)]
        public string CorreoElectronico { get; set; }

        [StringLength(12)]
        public string Telefono { get; set; }

        [StringLength(8)]
        public string Extencion { get; set; }

        [StringLength(12)]
        public string Celular { get; set; }

        public bool Activo { get; set; }

        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReporteBrigadas> tblReporteBrigadas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReporteBrigadas> tblReporteBrigadas1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReporteBrigadas> tblReporteBrigadas2 { get; set; }

        public virtual tblRoles tblRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnionesUsuarioUnidadAdministrativa> tblUnionesUsuarioUnidadAdministrativa { get; set; }
    }
}
