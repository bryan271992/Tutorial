﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tutorial.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class programacion5Entities : DbContext
    {
        public programacion5Entities()
            : base("name=programacion5Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<TBL_BITACORA_ERRORES> TBL_BITACORA_ERRORES { get; set; }
        public DbSet<TBL_CANTON> TBL_CANTON { get; set; }
        public DbSet<TBL_CORREOS> TBL_CORREOS { get; set; }
        public DbSet<TBL_DETALLE_TORNEO> TBL_DETALLE_TORNEO { get; set; }
        public DbSet<TBL_DISTRITO> TBL_DISTRITO { get; set; }
        public DbSet<TBL_ENC_TORNEOS> TBL_ENC_TORNEOS { get; set; }
        public DbSet<TBL_ENCUENTROS_X_TORNEO> TBL_ENCUENTROS_X_TORNEO { get; set; }
        public DbSet<TBL_EQUIPO> TBL_EQUIPO { get; set; }
        public DbSet<TBL_GOLEADORES> TBL_GOLEADORES { get; set; }
        public DbSet<TBL_INGRESOS_X_USUARIO> TBL_INGRESOS_X_USUARIO { get; set; }
        public DbSet<TBL_JUG_X_EQUIPO> TBL_JUG_X_EQUIPO { get; set; }
        public DbSet<TBL_JUGADORES> TBL_JUGADORES { get; set; }
        public DbSet<TBL_POSICIONES> TBL_POSICIONES { get; set; }
        public DbSet<TBL_PROVINCIA> TBL_PROVINCIA { get; set; }
        public DbSet<TBL_TELEFONOS> TBL_TELEFONOS { get; set; }
        public DbSet<TBL_TIPO_USUARIO> TBL_TIPO_USUARIO { get; set; }
        public DbSet<TBL_USUARIOS_LOG> TBL_USUARIOS_LOG { get; set; }
    
        public virtual ObjectResult<RetornaCantones_Result> RetornaCantones(string nombre, Nullable<int> id_Provincia)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var id_ProvinciaParameter = id_Provincia.HasValue ?
                new ObjectParameter("id_Provincia", id_Provincia) :
                new ObjectParameter("id_Provincia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaCantones_Result>("RetornaCantones", nombreParameter, id_ProvinciaParameter);
        }
    
        public virtual ObjectResult<RetornaCantonesID_Result> RetornaCantonesID(Nullable<int> id_Canton)
        {
            var id_CantonParameter = id_Canton.HasValue ?
                new ObjectParameter("id_Canton", id_Canton) :
                new ObjectParameter("id_Canton", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaCantonesID_Result>("RetornaCantonesID", id_CantonParameter);
        }
    
        public virtual ObjectResult<RetornaProvincias_Result> RetornaProvincias(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RetornaProvincias_Result>("RetornaProvincias", nombreParameter);
        }
    
        public virtual int SP_ACTUALIZAR_EQUIPO(Nullable<int> iD_PROVINCIA, Nullable<int> iD_CANTON, Nullable<int> iD_DISTRITO, string nOMBRE_EQUIPO, Nullable<System.DateTime> fUNDACION)
        {
            var iD_PROVINCIAParameter = iD_PROVINCIA.HasValue ?
                new ObjectParameter("ID_PROVINCIA", iD_PROVINCIA) :
                new ObjectParameter("ID_PROVINCIA", typeof(int));
    
            var iD_CANTONParameter = iD_CANTON.HasValue ?
                new ObjectParameter("ID_CANTON", iD_CANTON) :
                new ObjectParameter("ID_CANTON", typeof(int));
    
            var iD_DISTRITOParameter = iD_DISTRITO.HasValue ?
                new ObjectParameter("ID_DISTRITO", iD_DISTRITO) :
                new ObjectParameter("ID_DISTRITO", typeof(int));
    
            var nOMBRE_EQUIPOParameter = nOMBRE_EQUIPO != null ?
                new ObjectParameter("NOMBRE_EQUIPO", nOMBRE_EQUIPO) :
                new ObjectParameter("NOMBRE_EQUIPO", typeof(string));
    
            var fUNDACIONParameter = fUNDACION.HasValue ?
                new ObjectParameter("FUNDACION", fUNDACION) :
                new ObjectParameter("FUNDACION", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ACTUALIZAR_EQUIPO", iD_PROVINCIAParameter, iD_CANTONParameter, iD_DISTRITOParameter, nOMBRE_EQUIPOParameter, fUNDACIONParameter);
        }
    
        public virtual int SP_ACTUALIZAR_JUGADOR(string cEDULA, string nOMBRE, string aPELLIDO1, string aPELLIDO2, string tELEFONO, string cORREO, string dIRECCION)
        {
            var cEDULAParameter = cEDULA != null ?
                new ObjectParameter("CEDULA", cEDULA) :
                new ObjectParameter("CEDULA", typeof(string));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var aPELLIDO1Parameter = aPELLIDO1 != null ?
                new ObjectParameter("APELLIDO1", aPELLIDO1) :
                new ObjectParameter("APELLIDO1", typeof(string));
    
            var aPELLIDO2Parameter = aPELLIDO2 != null ?
                new ObjectParameter("APELLIDO2", aPELLIDO2) :
                new ObjectParameter("APELLIDO2", typeof(string));
    
            var tELEFONOParameter = tELEFONO != null ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(string));
    
            var cORREOParameter = cORREO != null ?
                new ObjectParameter("CORREO", cORREO) :
                new ObjectParameter("CORREO", typeof(string));
    
            var dIRECCIONParameter = dIRECCION != null ?
                new ObjectParameter("DIRECCION", dIRECCION) :
                new ObjectParameter("DIRECCION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ACTUALIZAR_JUGADOR", cEDULAParameter, nOMBREParameter, aPELLIDO1Parameter, aPELLIDO2Parameter, tELEFONOParameter, cORREOParameter, dIRECCIONParameter);
        }
    
        public virtual int SP_AGREGAR_JUGADOR_X_EQUIPO(string cEDULA, string nOMBRE_EQUIPO)
        {
            var cEDULAParameter = cEDULA != null ?
                new ObjectParameter("CEDULA", cEDULA) :
                new ObjectParameter("CEDULA", typeof(string));
    
            var nOMBRE_EQUIPOParameter = nOMBRE_EQUIPO != null ?
                new ObjectParameter("NOMBRE_EQUIPO", nOMBRE_EQUIPO) :
                new ObjectParameter("NOMBRE_EQUIPO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_AGREGAR_JUGADOR_X_EQUIPO", cEDULAParameter, nOMBRE_EQUIPOParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual ObjectResult<SP_CONSULTAR_LISTA_EQUIPOS_Result> SP_CONSULTAR_LISTA_EQUIPOS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CONSULTAR_LISTA_EQUIPOS_Result>("SP_CONSULTAR_LISTA_EQUIPOS");
        }
    
        public virtual ObjectResult<SP_CONSULTAR_LISTA_JUGADORES_Result> SP_CONSULTAR_LISTA_JUGADORES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CONSULTAR_LISTA_JUGADORES_Result>("SP_CONSULTAR_LISTA_JUGADORES");
        }
    
        public virtual ObjectResult<SP_CONSULTAR_PROVINCIAS_Result> SP_CONSULTAR_PROVINCIAS(string nombre)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_CONSULTAR_PROVINCIAS_Result>("SP_CONSULTAR_PROVINCIAS", nombreParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_EliminaCanton(Nullable<int> id_Canton)
        {
            var id_CantonParameter = id_Canton.HasValue ?
                new ObjectParameter("id_Canton", id_Canton) :
                new ObjectParameter("id_Canton", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_EliminaCanton", id_CantonParameter);
        }
    
        public virtual int SP_ELIMINAR_EQUIPO(string nOMBRE_EQUIPO)
        {
            var nOMBRE_EQUIPOParameter = nOMBRE_EQUIPO != null ?
                new ObjectParameter("NOMBRE_EQUIPO", nOMBRE_EQUIPO) :
                new ObjectParameter("NOMBRE_EQUIPO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ELIMINAR_EQUIPO", nOMBRE_EQUIPOParameter);
        }
    
        public virtual int SP_ELIMINAR_JUGADOR(string cEDULA)
        {
            var cEDULAParameter = cEDULA != null ?
                new ObjectParameter("CEDULA", cEDULA) :
                new ObjectParameter("CEDULA", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ELIMINAR_JUGADOR", cEDULAParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_InsertaCanton(Nullable<int> id_Provincia, string nombre, Nullable<int> id_CantonInec)
        {
            var id_ProvinciaParameter = id_Provincia.HasValue ?
                new ObjectParameter("id_Provincia", id_Provincia) :
                new ObjectParameter("id_Provincia", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var id_CantonInecParameter = id_CantonInec.HasValue ?
                new ObjectParameter("id_CantonInec", id_CantonInec) :
                new ObjectParameter("id_CantonInec", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertaCanton", id_ProvinciaParameter, nombreParameter, id_CantonInecParameter);
        }
    
        public virtual int sp_ModificaCanton(Nullable<int> id_Canton, Nullable<int> id_Provincia, string nombre, Nullable<int> id_CantonInec)
        {
            var id_CantonParameter = id_Canton.HasValue ?
                new ObjectParameter("id_Canton", id_Canton) :
                new ObjectParameter("id_Canton", typeof(int));
    
            var id_ProvinciaParameter = id_Provincia.HasValue ?
                new ObjectParameter("id_Provincia", id_Provincia) :
                new ObjectParameter("id_Provincia", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var id_CantonInecParameter = id_CantonInec.HasValue ?
                new ObjectParameter("id_CantonInec", id_CantonInec) :
                new ObjectParameter("id_CantonInec", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_ModificaCanton", id_CantonParameter, id_ProvinciaParameter, nombreParameter, id_CantonInecParameter);
        }
    
        public virtual int SP_REGISTRA_EQUIPO(Nullable<int> iD_PROVINCIA, Nullable<int> iD_CANTON, Nullable<int> iD_DISTRITO, string nOMBRE_EQUIPO, Nullable<System.DateTime> fUNDACION)
        {
            var iD_PROVINCIAParameter = iD_PROVINCIA.HasValue ?
                new ObjectParameter("ID_PROVINCIA", iD_PROVINCIA) :
                new ObjectParameter("ID_PROVINCIA", typeof(int));
    
            var iD_CANTONParameter = iD_CANTON.HasValue ?
                new ObjectParameter("ID_CANTON", iD_CANTON) :
                new ObjectParameter("ID_CANTON", typeof(int));
    
            var iD_DISTRITOParameter = iD_DISTRITO.HasValue ?
                new ObjectParameter("ID_DISTRITO", iD_DISTRITO) :
                new ObjectParameter("ID_DISTRITO", typeof(int));
    
            var nOMBRE_EQUIPOParameter = nOMBRE_EQUIPO != null ?
                new ObjectParameter("NOMBRE_EQUIPO", nOMBRE_EQUIPO) :
                new ObjectParameter("NOMBRE_EQUIPO", typeof(string));
    
            var fUNDACIONParameter = fUNDACION.HasValue ?
                new ObjectParameter("FUNDACION", fUNDACION) :
                new ObjectParameter("FUNDACION", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_REGISTRA_EQUIPO", iD_PROVINCIAParameter, iD_CANTONParameter, iD_DISTRITOParameter, nOMBRE_EQUIPOParameter, fUNDACIONParameter);
        }
    
        public virtual int SP_REGISTRAR_JUGADOR(string cEDULA, string gENERO, Nullable<System.DateTime> fECHA_NACIMIENTO, string nOMBRE, string aPELLIDO1, string aPELLIDO2, string tELEFONO, string cORREO, Nullable<int> iD_PROVINCIA, Nullable<int> iD_CANTON, Nullable<int> iD_DISTRITO, string dIRECCION)
        {
            var cEDULAParameter = cEDULA != null ?
                new ObjectParameter("CEDULA", cEDULA) :
                new ObjectParameter("CEDULA", typeof(string));
    
            var gENEROParameter = gENERO != null ?
                new ObjectParameter("GENERO", gENERO) :
                new ObjectParameter("GENERO", typeof(string));
    
            var fECHA_NACIMIENTOParameter = fECHA_NACIMIENTO.HasValue ?
                new ObjectParameter("FECHA_NACIMIENTO", fECHA_NACIMIENTO) :
                new ObjectParameter("FECHA_NACIMIENTO", typeof(System.DateTime));
    
            var nOMBREParameter = nOMBRE != null ?
                new ObjectParameter("NOMBRE", nOMBRE) :
                new ObjectParameter("NOMBRE", typeof(string));
    
            var aPELLIDO1Parameter = aPELLIDO1 != null ?
                new ObjectParameter("APELLIDO1", aPELLIDO1) :
                new ObjectParameter("APELLIDO1", typeof(string));
    
            var aPELLIDO2Parameter = aPELLIDO2 != null ?
                new ObjectParameter("APELLIDO2", aPELLIDO2) :
                new ObjectParameter("APELLIDO2", typeof(string));
    
            var tELEFONOParameter = tELEFONO != null ?
                new ObjectParameter("TELEFONO", tELEFONO) :
                new ObjectParameter("TELEFONO", typeof(string));
    
            var cORREOParameter = cORREO != null ?
                new ObjectParameter("CORREO", cORREO) :
                new ObjectParameter("CORREO", typeof(string));
    
            var iD_PROVINCIAParameter = iD_PROVINCIA.HasValue ?
                new ObjectParameter("ID_PROVINCIA", iD_PROVINCIA) :
                new ObjectParameter("ID_PROVINCIA", typeof(int));
    
            var iD_CANTONParameter = iD_CANTON.HasValue ?
                new ObjectParameter("ID_CANTON", iD_CANTON) :
                new ObjectParameter("ID_CANTON", typeof(int));
    
            var iD_DISTRITOParameter = iD_DISTRITO.HasValue ?
                new ObjectParameter("ID_DISTRITO", iD_DISTRITO) :
                new ObjectParameter("ID_DISTRITO", typeof(int));
    
            var dIRECCIONParameter = dIRECCION != null ?
                new ObjectParameter("DIRECCION", dIRECCION) :
                new ObjectParameter("DIRECCION", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_REGISTRAR_JUGADOR", cEDULAParameter, gENEROParameter, fECHA_NACIMIENTOParameter, nOMBREParameter, aPELLIDO1Parameter, aPELLIDO2Parameter, tELEFONOParameter, cORREOParameter, iD_PROVINCIAParameter, iD_CANTONParameter, iD_DISTRITOParameter, dIRECCIONParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual ObjectResult<SP_RETORNAR_DISTRITO_Result> SP_RETORNAR_DISTRITO(string nombre, Nullable<int> id_Canton)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var id_CantonParameter = id_Canton.HasValue ?
                new ObjectParameter("id_Canton", id_Canton) :
                new ObjectParameter("id_Canton", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_RETORNAR_DISTRITO_Result>("SP_RETORNAR_DISTRITO", nombreParameter, id_CantonParameter);
        }
    
        public virtual ObjectResult<SP_ROTORNAR_CANTON_Result> SP_ROTORNAR_CANTON(string nombre, Nullable<int> id_Provincia)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("nombre", nombre) :
                new ObjectParameter("nombre", typeof(string));
    
            var id_ProvinciaParameter = id_Provincia.HasValue ?
                new ObjectParameter("id_Provincia", id_Provincia) :
                new ObjectParameter("id_Provincia", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ROTORNAR_CANTON_Result>("SP_ROTORNAR_CANTON", nombreParameter, id_ProvinciaParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<SP_VALIDAR_INICIO_SESION_Result> SP_VALIDAR_INICIO_SESION(string uSUARIO, string pASS)
        {
            var uSUARIOParameter = uSUARIO != null ?
                new ObjectParameter("USUARIO", uSUARIO) :
                new ObjectParameter("USUARIO", typeof(string));
    
            var pASSParameter = pASS != null ?
                new ObjectParameter("PASS", pASS) :
                new ObjectParameter("PASS", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_VALIDAR_INICIO_SESION_Result>("SP_VALIDAR_INICIO_SESION", uSUARIOParameter, pASSParameter);
        }
    }
}
