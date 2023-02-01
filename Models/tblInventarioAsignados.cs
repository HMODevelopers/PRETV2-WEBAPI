namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblInventarioAsignados
    {
        [Key]
        public int InventarioAsignadoId { get; set; }

        public int ct_id { get; set; }

        public int TipoEquipoId { get; set; }

        public int MarcaId { get; set; }

        [Required]
        [StringLength(100)]
        public string Modelo { get; set; }

        [Required]
        [StringLength(100)]
        public string NoInventario { get; set; }

        [Required]
        [StringLength(100)]
        public string NoSerie { get; set; }

        [Required]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(250)]
        public string NombreResponsable { get; set; }

        [Required]
        [StringLength(250)]
        public string PuestoResponsable { get; set; }

        [Required]
        [StringLength(250)]
        public string Ubicacion { get; set; }

        public int EstatusInventario { get; set; }

        public string Comentarios { get; set; }

        public bool Activo { get; set; }

        public int OrigenRecursoId { get; set; }

        public int? ProgramaId { get; set; }

        public int? SistemaOperativoId { get; set; }

        public int? VersionOfficeId { get; set; }

        public string DiscoDuro { get; set; }

        public string MemoriaRam { get; set; }

        public string Procesador { get; set; }

        public virtual tblCentrosdetrabajo tblCentrosdetrabajo { get; set; }

        public virtual tblMarcas tblMarcas { get; set; }

        public virtual tblOrigenesRecurso tblOrigenesRecurso { get; set; }

        public virtual tblSistemasOperativos tblSistemasOperativos { get; set; }

        public virtual tblTiposEquipo tblTiposEquipo { get; set; }

        public virtual tblVersionesOffice tblVersionesOffice { get; set; }
    }
}
