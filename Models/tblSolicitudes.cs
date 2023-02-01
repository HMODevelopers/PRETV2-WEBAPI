namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblSolicitudes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblSolicitudes()
        {
            tblAsignacionesSolicitudes = new HashSet<tblAsignacionesSolicitudes>();
        }

        [Key]
        public int SolicitudId { get; set; }

        [Required]
        public string Folio { get; set; }

        public int? ct_id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string ApellidoPaterno { get; set; }

        [StringLength(200)]
        public string ApellidoMaterno { get; set; }

        [Required]
        [StringLength(100)]
        public string CorreoElectronico { get; set; }

        [StringLength(12)]
        public string Telefono { get; set; }

        [StringLength(8)]
        public string Extencion { get; set; }

        public int TipoUsuarioId { get; set; }

        public int TipoSolicitudId { get; set; }

        public int SubtipoSolicitudId { get; set; }

        [Required]
        public string Peticion { get; set; }

        public int TipoModalidadId { get; set; }

        public int Estatus { get; set; }

        public DateTime FechaCreacion { get; set; }

        public bool Activo { get; set; }

        public string Oficio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAsignacionesSolicitudes> tblAsignacionesSolicitudes { get; set; }

        public virtual tblCentrosdetrabajo tblCentrosdetrabajo { get; set; }

        public virtual tblTipoModalidades tblTipoModalidades { get; set; }

        public virtual tblTiposSolicitud tblTiposSolicitud { get; set; }

        public virtual tblTipoUsuarios tblTipoUsuarios { get; set; }
    }
}
