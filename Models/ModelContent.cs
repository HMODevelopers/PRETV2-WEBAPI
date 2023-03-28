using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Models
{
    public partial class ModelContent : DbContext
    {
        public ModelContent()
            : base("name=ModelContent")
        {
        }

        public virtual DbSet<cat_ambito> cat_ambito { get; set; }
        public virtual DbSet<cat_proveedores> cat_proveedores { get; set; }
        public virtual DbSet<cat_tipo_conect> cat_tipo_conect { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblActividadesReporte> tblActividadesReporte { get; set; }
        public virtual DbSet<tblAsignacionesSolicitudes> tblAsignacionesSolicitudes { get; set; }
        public virtual DbSet<tblBitacora> tblBitacora { get; set; }
        public virtual DbSet<tblCatalogosBitacora> tblCatalogosBitacora { get; set; }
        public virtual DbSet<tblCentrosdetrabajo> tblCentrosdetrabajo { get; set; }
        public virtual DbSet<tblCiclosEscolares> tblCiclosEscolares { get; set; }
        public virtual DbSet<tblcodigo_postal> tblcodigo_postal { get; set; }
        public virtual DbSet<tblconnections> tblconnections { get; set; }
        public virtual DbSet<tbldetalle_ct_turno> tbldetalle_ct_turno { get; set; }
        public virtual DbSet<tblDirectorio> tblDirectorio { get; set; }
        public virtual DbSet<tblDocentes> tblDocentes { get; set; }
        public virtual DbSet<tblestatus> tblestatus { get; set; }
        public virtual DbSet<tblEstatusReporte> tblEstatusReporte { get; set; }
        public virtual DbSet<tblFormacion> tblFormacion { get; set; }
        public virtual DbSet<tblGruposCatalagos> tblGruposCatalagos { get; set; }
        public virtual DbSet<tblinmueble> tblinmueble { get; set; }
        public virtual DbSet<tblInventarioAsignados> tblInventarioAsignados { get; set; }
        public virtual DbSet<tbllocalidades> tbllocalidades { get; set; }
        public virtual DbSet<tblMarcas> tblMarcas { get; set; }
        public virtual DbSet<tblModalidadFormacion> tblModalidadFormacion { get; set; }
        public virtual DbSet<tblmunicipios> tblmunicipios { get; set; }
        public virtual DbSet<tblnivel_educativo> tblnivel_educativo { get; set; }
        public virtual DbSet<tblOrigenesRecurso> tblOrigenesRecurso { get; set; }
        public virtual DbSet<tblPermisos> tblPermisos { get; set; }
        public virtual DbSet<tblPermisosRoles> tblPermisosRoles { get; set; }
        public virtual DbSet<tblReporteBrigadas> tblReporteBrigadas { get; set; }
        public virtual DbSet<tblReporteConect> tblReporteConect { get; set; }
        public virtual DbSet<tblReporteDireccion> tblReporteDireccion { get; set; }
        public virtual DbSet<tblRoles> tblRoles { get; set; }
        public virtual DbSet<tblsector> tblsector { get; set; }
        public virtual DbSet<tblservicios> tblservicios { get; set; }
        public virtual DbSet<tblSistemasOperativos> tblSistemasOperativos { get; set; }
        public virtual DbSet<tblsnivel_educativo> tblsnivel_educativo { get; set; }
        public virtual DbSet<tblSolicitudes> tblSolicitudes { get; set; }
        public virtual DbSet<tblssnivel_educativo> tblssnivel_educativo { get; set; }
        public virtual DbSet<tblstipo> tblstipo { get; set; }
        public virtual DbSet<tblSubtiposSolicitud> tblSubtiposSolicitud { get; set; }
        public virtual DbSet<tbltcompleto> tbltcompleto { get; set; }
        public virtual DbSet<tbltipo> tbltipo { get; set; }
        public virtual DbSet<tblTipoFormacion> tblTipoFormacion { get; set; }
        public virtual DbSet<tblTipoModalidades> tblTipoModalidades { get; set; }
        public virtual DbSet<tblTiposEquipo> tblTiposEquipo { get; set; }
        public virtual DbSet<tblTiposSolicitud> tblTiposSolicitud { get; set; }
        public virtual DbSet<tblTipoUsuarios> tblTipoUsuarios { get; set; }
        public virtual DbSet<tblturnos> tblturnos { get; set; }
        public virtual DbSet<tbludch> tbludch { get; set; }
        public virtual DbSet<tbludche> tbludche { get; set; }
        public virtual DbSet<tblUnidadesAdministrativas> tblUnidadesAdministrativas { get; set; }
        public virtual DbSet<tblUnionesMarcaTipoEquipo> tblUnionesMarcaTipoEquipo { get; set; }
        public virtual DbSet<tblUnionesUsuarioUnidadAdministrativa> tblUnionesUsuarioUnidadAdministrativa { get; set; }
        public virtual DbSet<tblUnionFormacionDocentes> tblUnionFormacionDocentes { get; set; }
        public virtual DbSet<tblUnionReporteBrigadaReporteConect> tblUnionReporteBrigadaReporteConect { get; set; }
        public virtual DbSet<tblUnionReporteBrigadaReporteDireccion> tblUnionReporteBrigadaReporteDireccion { get; set; }
        public virtual DbSet<tblUnionReportesBrigadasActividades> tblUnionReportesBrigadasActividades { get; set; }
        public virtual DbSet<tbluso> tbluso { get; set; }
        public virtual DbSet<tblUsuarios> tblUsuarios { get; set; }
        public virtual DbSet<tblVersionesOffice> tblVersionesOffice { get; set; }
        public virtual DbSet<tblzonas> tblzonas { get; set; }
        public virtual DbSet<talbergados> talbergados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cat_ambito>()
                .HasMany(e => e.tblconnections)
                .WithRequired(e => e.cat_ambito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cat_proveedores>()
                .HasMany(e => e.tblconnections)
                .WithRequired(e => e.cat_proveedores)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cat_tipo_conect>()
                .HasMany(e => e.tblconnections)
                .WithRequired(e => e.cat_tipo_conect)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblActividadesReporte>()
                .Property(e => e.NombreActividad)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_clave)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_numero)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_calle)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_entrecalle)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_ycalle)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_callepost)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_email)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_lada)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_latitud)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_longitud)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_altitud)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_zona_economica)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_udsh)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_clave_ads)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_claveinsti)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .Property(e => e.ct_observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .HasMany(e => e.tblDocentes)
                .WithRequired(e => e.tblCentrosdetrabajo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .HasMany(e => e.tblInventarioAsignados)
                .WithRequired(e => e.tblCentrosdetrabajo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .HasMany(e => e.tblReporteBrigadas)
                .WithRequired(e => e.tblCentrosdetrabajo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .HasMany(e => e.tblconnections)
                .WithRequired(e => e.tblCentrosdetrabajo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCentrosdetrabajo>()
                .HasMany(e => e.tbldetalle_ct_turno)
                .WithRequired(e => e.tblCentrosdetrabajo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCiclosEscolares>()
                .HasMany(e => e.tblFormacion)
                .WithRequired(e => e.tblCiclosEscolares)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblcodigo_postal>()
                .Property(e => e.cod_cp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblconnections>()
                .Property(e => e.lat)
                .HasPrecision(20, 10);

            modelBuilder.Entity<tblconnections>()
                .Property(e => e._long)
                .HasPrecision(20, 10);

            modelBuilder.Entity<tblDirectorio>()
                .Property(e => e.NombreDirector)
                .IsUnicode(false);

            modelBuilder.Entity<tblDirectorio>()
                .Property(e => e.NombreContacto)
                .IsUnicode(false);

            modelBuilder.Entity<tblDocentes>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<tblDocentes>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<tblDocentes>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<tblDocentes>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<tblDocentes>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<tblDocentes>()
                .Property(e => e.Curp)
                .IsUnicode(false);

            modelBuilder.Entity<tblDocentes>()
                .Property(e => e.CorreoElectronico)
                .IsUnicode(false);

            modelBuilder.Entity<tblDocentes>()
                .HasMany(e => e.tblUnionFormacionDocentes)
                .WithRequired(e => e.tblDocentes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblestatus>()
                .Property(e => e.est_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tblEstatusReporte>()
                .Property(e => e.NombreEstatus)
                .IsUnicode(false);

            modelBuilder.Entity<tblFormacion>()
                .Property(e => e.NombreFormacion)
                .IsUnicode(false);

            modelBuilder.Entity<tblFormacion>()
                .Property(e => e.NombreCapacitor)
                .IsUnicode(false);

            modelBuilder.Entity<tblFormacion>()
                .Property(e => e.Duracion)
                .IsUnicode(false);

            modelBuilder.Entity<tblFormacion>()
                .Property(e => e.InstanciaCapacitora)
                .IsUnicode(false);

            modelBuilder.Entity<tblFormacion>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<tblFormacion>()
                .HasMany(e => e.tblUnionFormacionDocentes)
                .WithRequired(e => e.tblFormacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblinmueble>()
                .Property(e => e.inm_val_cata)
                .HasPrecision(12, 2);

            modelBuilder.Entity<tblinmueble>()
                .HasOptional(e => e.talbergados)
                .WithRequired(e => e.tblinmueble);

            modelBuilder.Entity<tbllocalidades>()
                .Property(e => e.mun_inegiid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbllocalidades>()
                .Property(e => e.loc_inegiid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbllocalidades>()
                .Property(e => e.loc_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tblMarcas>()
                .HasMany(e => e.tblInventarioAsignados)
                .WithRequired(e => e.tblMarcas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblMarcas>()
                .HasMany(e => e.tblUnionesMarcaTipoEquipo)
                .WithRequired(e => e.tblMarcas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblModalidadFormacion>()
                .Property(e => e.NombreModalidad)
                .IsUnicode(false);

            modelBuilder.Entity<tblModalidadFormacion>()
                .HasMany(e => e.tblFormacion)
                .WithRequired(e => e.tblModalidadFormacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblmunicipios>()
                .Property(e => e.mun_inegiid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblmunicipios>()
                .Property(e => e.mun_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tblmunicipios>()
                .Property(e => e.mun_entinegiid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblmunicipios>()
                .Property(e => e.zest_zona)
                .IsUnicode(false);

            modelBuilder.Entity<tblmunicipios>()
                .Property(e => e.udch)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblmunicipios>()
                .HasMany(e => e.tbllocalidades)
                .WithRequired(e => e.tblmunicipios)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblnivel_educativo>()
                .Property(e => e.niv_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tblnivel_educativo>()
                .HasMany(e => e.tblsnivel_educativo)
                .WithRequired(e => e.tblnivel_educativo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrigenesRecurso>()
                .HasMany(e => e.tblInventarioAsignados)
                .WithRequired(e => e.tblOrigenesRecurso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblReporteBrigadas>()
                .Property(e => e.FolioReporteGeneral)
                .IsUnicode(false);

            modelBuilder.Entity<tblReporteBrigadas>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<tblReporteBrigadas>()
                .Property(e => e.Diagnostico)
                .IsFixedLength();

            modelBuilder.Entity<tblReporteBrigadas>()
                .Property(e => e.Seguimiento)
                .IsUnicode(false);

            modelBuilder.Entity<tblReporteConect>()
                .Property(e => e.FolioConectividad)
                .IsUnicode(false);

            modelBuilder.Entity<tblReporteConect>()
                .Property(e => e.ReporteProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<tblReporteConect>()
                .Property(e => e.Subida)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblReporteConect>()
                .Property(e => e.Bajada)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tblReporteConect>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<tblReporteConect>()
                .Property(e => e.Diagnostico)
                .IsFixedLength();

            modelBuilder.Entity<tblReporteConect>()
                .Property(e => e.Seguimiento)
                .IsFixedLength();

            modelBuilder.Entity<tblReporteDireccion>()
                .Property(e => e.FolioDireccion)
                .IsUnicode(false);

            modelBuilder.Entity<tblReporteDireccion>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<tblReporteDireccion>()
                .Property(e => e.Diagnostico)
                .IsFixedLength();

            modelBuilder.Entity<tblReporteDireccion>()
                .Property(e => e.Seguimiento)
                .IsUnicode(false);

            modelBuilder.Entity<tblReporteDireccion>()
                .Property(e => e.CorreoOficial)
                .IsUnicode(false);

            modelBuilder.Entity<tblsector>()
                .Property(e => e.sec_sector)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblservicios>()
                .Property(e => e.cla_clasificacion)
                .IsFixedLength();

            modelBuilder.Entity<tblservicios>()
                .Property(e => e.ser_servicio)
                .IsFixedLength();

            modelBuilder.Entity<tblsnivel_educativo>()
                .Property(e => e.sniv_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tblSolicitudes>()
                .HasMany(e => e.tblAsignacionesSolicitudes)
                .WithRequired(e => e.tblSolicitudes)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblssnivel_educativo>()
                .Property(e => e.ssniv_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tblstipo>()
                .Property(e => e.stip_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tblstipo>()
                .Property(e => e.stip_sostenimie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbltcompleto>()
                .Property(e => e.tco_tcompleto)
                .IsFixedLength();

            modelBuilder.Entity<tbltipo>()
                .Property(e => e.tip_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tblTipoFormacion>()
                .Property(e => e.NombreTipoFormacion)
                .IsUnicode(false);

            modelBuilder.Entity<tblTipoFormacion>()
                .HasOptional(e => e.tblFormacion)
                .WithRequired(e => e.tblTipoFormacion);

            modelBuilder.Entity<tblTipoModalidades>()
                .HasMany(e => e.tblSolicitudes)
                .WithRequired(e => e.tblTipoModalidades)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTiposEquipo>()
                .HasMany(e => e.tblInventarioAsignados)
                .WithRequired(e => e.tblTiposEquipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTiposEquipo>()
                .HasMany(e => e.tblUnionesMarcaTipoEquipo)
                .WithRequired(e => e.tblTiposEquipo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTiposSolicitud>()
                .HasMany(e => e.tblSolicitudes)
                .WithRequired(e => e.tblTiposSolicitud)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTipoUsuarios>()
                .HasMany(e => e.tblSolicitudes)
                .WithRequired(e => e.tblTipoUsuarios)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblturnos>()
                .Property(e => e.tur_nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tblturnos>()
                .Property(e => e.tur_desc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblturnos>()
                .Property(e => e.tur_abr)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblturnos>()
                .HasMany(e => e.tbldetalle_ct_turno)
                .WithRequired(e => e.tblturnos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbludch>()
                .Property(e => e.uds_udch)
                .IsFixedLength();

            modelBuilder.Entity<tbludche>()
                .Property(e => e.uds_udch)
                .IsFixedLength();

            modelBuilder.Entity<tbludche>()
                .Property(e => e.uds_nudch)
                .IsFixedLength();

            modelBuilder.Entity<tblUnidadesAdministrativas>()
                .HasMany(e => e.tblAsignacionesSolicitudes)
                .WithRequired(e => e.tblUnidadesAdministrativas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbluso>()
                .Property(e => e.uso_descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<tblUsuarios>()
                .HasMany(e => e.tblReporteBrigadas)
                .WithOptional(e => e.tblUsuarios)
                .HasForeignKey(e => e.AcompananteUsuarioId);

            modelBuilder.Entity<tblUsuarios>()
                .HasMany(e => e.tblReporteBrigadas1)
                .WithOptional(e => e.tblUsuarios1)
                .HasForeignKey(e => e.ResolvioUsuarioId);

            modelBuilder.Entity<tblUsuarios>()
                .HasMany(e => e.tblReporteBrigadas2)
                .WithOptional(e => e.tblUsuarios2)
                .HasForeignKey(e => e.LevantoUsuarioId);

            modelBuilder.Entity<tblzonas>()
                .Property(e => e.zon_zona)
                .IsFixedLength()
                .IsUnicode(false);

            //modelBuilder.Entity<tblReporteBrigadas>()
            //   .HasMany(e => e.tblUnionReporteBrigadaReporteDireccion)
            //   .WithRequired(e => e.tblReporteBrigadas)
            //   .HasForeignKey(e => e.ReporteGeneralId);

            //modelBuilder.Entity<tblReporteConect>()
            //    .HasMany(e => e.tblUnionReporteBrigadaReporteConect)
            //    .WithRequired(e => e.tblReporteConect)
            //    .HasForeignKey(e => e.ReporteConectId);
        }
    }
}
