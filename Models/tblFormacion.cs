namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblFormacion")]
    public partial class tblFormacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblFormacion()
        {
            tblUnionFormacionDocentes = new HashSet<tblUnionFormacionDocentes>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FormacionId { get; set; }

        public int? UnidadAdministrativaId { get; set; }

        [Required]
        [StringLength(50)]
        public string NombreFormacion { get; set; }

        [Required]
        [StringLength(255)]
        public string NombreCapacitor { get; set; }

        public int ModalidadFormacionId { get; set; }

        public int CicloEscolarId { get; set; }

        public DateTime PeriodoInicio { get; set; }

        public DateTime PeriodoFinal { get; set; }

        public int TipoFormacionId { get; set; }

        [Required]
        [StringLength(50)]
        public string Duracion { get; set; }

        [Required]
        [StringLength(50)]
        public string InstanciaCapacitora { get; set; }

        [Required]
        [StringLength(500)]
        public string Observacion { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaCreacion { get; set; }

        public virtual tblCiclosEscolares tblCiclosEscolares { get; set; }

        public virtual tblModalidadFormacion tblModalidadFormacion { get; set; }

        public virtual tblUnidadesAdministrativas tblUnidadesAdministrativas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnionFormacionDocentes> tblUnionFormacionDocentes { get; set; }

        public virtual tblTipoFormacion tblTipoFormacion { get; set; }
    }
}
