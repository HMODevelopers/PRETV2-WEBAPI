namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblinmueble")]
    public partial class tblinmueble
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int inm_id { get; set; }

        public int? ct_id { get; set; }

        [StringLength(10)]
        public string ct_clave { get; set; }

        [StringLength(60)]
        public string inm_nombre { get; set; }

        [StringLength(60)]
        public string inm_municipio { get; set; }

        [StringLength(60)]
        public string inm_localidad { get; set; }

        [StringLength(20)]
        public string inm_cve_cat { get; set; }

        [StringLength(255)]
        public string inm_domicilio { get; set; }

        [StringLength(60)]
        public string inm_propietario { get; set; }

        [StringLength(20)]
        public string inm_terreno_m2 { get; set; }

        [StringLength(20)]
        public string inm_constr_m2 { get; set; }

        public decimal? inm_val_cata { get; set; }

        [StringLength(100)]
        public string inm_uso { get; set; }

        [Column(TypeName = "date")]
        public DateTime? inm_fecha_reg { get; set; }

        public int? sta_id { get; set; }

        public int? sta_id_1 { get; set; }

        public int? sta_id_2 { get; set; }

        [StringLength(255)]
        public string inm_soste { get; set; }

        public virtual tblCentrosdetrabajo tblCentrosdetrabajo { get; set; }

        public virtual talbergados talbergados { get; set; }

        public virtual tbltcompleto tbltcompleto { get; set; }
    }
}
