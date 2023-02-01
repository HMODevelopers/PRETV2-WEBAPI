namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblModalidadFormacion")]
    public partial class tblModalidadFormacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblModalidadFormacion()
        {
            tblFormacion = new HashSet<tblFormacion>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ModalidadFormacionId { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreModalidad { get; set; }

        public bool Activo { get; set; }

        public DateTime FechaCreacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFormacion> tblFormacion { get; set; }
    }
}
