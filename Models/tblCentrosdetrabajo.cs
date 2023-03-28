namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCentrosdetrabajo")]
    public partial class tblCentrosdetrabajo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCentrosdetrabajo()
        {
            tblDocentes = new HashSet<tblDocentes>();
            tblDirectorio = new HashSet<tblDirectorio>();
            tblInventarioAsignados = new HashSet<tblInventarioAsignados>();
            tblReporteBrigadas = new HashSet<tblReporteBrigadas>();
            tblReporteConect = new HashSet<tblReporteConect>();
            tblReporteDireccion = new HashSet<tblReporteDireccion>();
            tblSolicitudes = new HashSet<tblSolicitudes>();
            tblconnections = new HashSet<tblconnections>();
            tbldetalle_ct_turno = new HashSet<tbldetalle_ct_turno>();
            //tblinmueble = new HashSet<tblinmueble>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ct_id { get; set; }

        [Required]
        [StringLength(10)]
        public string ct_clave { get; set; }

        [StringLength(100)]
        public string ct_nombre { get; set; }

        public int? niv_id { get; set; }

        public int? sniv_id { get; set; }

        public int? ssniv_id { get; set; }

        public int? tip_id { get; set; }

        public int? stip_id { get; set; }

        [StringLength(20)]
        public string ct_numero { get; set; }

        [StringLength(100)]
        public string ct_calle { get; set; }

        [StringLength(100)]
        public string ct_entrecalle { get; set; }

        [StringLength(100)]
        public string ct_ycalle { get; set; }

        [StringLength(60)]
        public string ct_callepost { get; set; }

        [StringLength(40)]
        public string ct_email { get; set; }

        public int? ct_telefono { get; set; }

        [StringLength(6)]
        public string ct_lada { get; set; }

        public int? ct_telefono_movil { get; set; }

        public int? col_id { get; set; }

        public int? codcp_id { get; set; }

        public int? loc_id { get; set; }

        public int? mun_id { get; set; }

        [StringLength(40)]
        public string ct_latitud { get; set; }

        [StringLength(40)]
        public string ct_longitud { get; set; }

        [StringLength(4)]
        public string ct_altitud { get; set; }

        public int? rep_id { get; set; }

        public int? ct_id_empleado { get; set; }

        public int? reg_id { get; set; }

        public int? uso_id { get; set; }

        public int? est_id { get; set; }

        [StringLength(45)]
        public string ct_zona_economica { get; set; }

        [StringLength(45)]
        public string ct_udsh { get; set; }

        public int? sec_id { get; set; }

        [StringLength(45)]
        public string ct_clave_ads { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ct_fecha_sol { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ct_fecha_fund { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ct_fecha_alta { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ct_fecha_cla { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ct_fecha_reap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ct_fecha_cam { get; set; }

        public int? inc_id { get; set; }

        public int? ori_id { get; set; }

        public int? sit_id { get; set; }

        public int? inm_id { get; set; }

        public int? zon_id { get; set; }

        public int nor_id { get; set; }

        public int adm_id { get; set; }

        public int? id_servicio { get; set; }

        [StringLength(10)]
        public string ct_claveinsti { get; set; }

        [StringLength(100)]
        public string ct_observaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDocentes> tblDocentes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDirectorio> tblDirectorio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblInventarioAsignados> tblInventarioAsignados { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReporteBrigadas> tblReporteBrigadas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReporteConect> tblReporteConect { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblReporteDireccion> tblReporteDireccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSolicitudes> tblSolicitudes { get; set; }

        public virtual tblcodigo_postal tblcodigo_postal { get; set; }

        public virtual tblestatus tblestatus { get; set; }

        public virtual tblmunicipios tblmunicipios { get; set; }

        public virtual tblnivel_educativo tblnivel_educativo { get; set; }

        public virtual tblsector tblsector { get; set; }

        public virtual tblservicios tblservicios { get; set; }

        public virtual tblssnivel_educativo tblssnivel_educativo { get; set; }

        public virtual tbltipo tbltipo { get; set; }

        public virtual tbluso tbluso { get; set; }

        public virtual tblzonas tblzonas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblconnections> tblconnections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbldetalle_ct_turno> tbldetalle_ct_turno { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<tblinmueble> tblinmueble { get; set; }
    }
}
