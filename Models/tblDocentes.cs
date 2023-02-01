namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblDocentes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblDocentes()
        {
            tblUnionFormacionDocentes = new HashSet<tblUnionFormacionDocentes>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DocenteId { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(255)]
        public string ApellidoPaterno { get; set; }

        [Required]
        [StringLength(255)]
        public string ApellidoMaterno { get; set; }

        [Required]
        [StringLength(50)]
        public string Sexo { get; set; }

        public int Edad { get; set; }

        [Required]
        [StringLength(50)]
        public string RFC { get; set; }

        [Required]
        [StringLength(50)]
        public string Curp { get; set; }

        [Required]
        [StringLength(50)]
        public string CorreoElectronico { get; set; }

        public int Telefono { get; set; }

        public int Celular { get; set; }

        public int ct_id { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaCreacion { get; set; }

        public virtual tblCentrosdetrabajo tblCentrosdetrabajo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUnionFormacionDocentes> tblUnionFormacionDocentes { get; set; }
    }
}
