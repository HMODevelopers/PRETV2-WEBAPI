namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblAsignacionesSolicitudes
    {
        [Key]
        public int AsignacionSolicitudId { get; set; }

        public int SolicitudId { get; set; }

        public int UnidadAdministrativaId { get; set; }

        public int Estatus { get; set; }

        [Required]
        public string Comentario { get; set; }

        public string Resolucion { get; set; }

        public bool Activo { get; set; }

        public int? ResueltoPorUsuarioId { get; set; }

        public virtual tblSolicitudes tblSolicitudes { get; set; }

        public virtual tblUnidadesAdministrativas tblUnidadesAdministrativas { get; set; }
    }
}
