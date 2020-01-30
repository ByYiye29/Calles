﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Carreteras
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class carreteras_finalEntities : DbContext
    {
        public carreteras_finalEntities()
            : base("name=carreteras_finalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_carreteras> tb_carreteras { get; set; }
        public virtual DbSet<tb_carreterasXciudades> tb_carreterasXciudades { get; set; }
        public virtual DbSet<tb_ciudades> tb_ciudades { get; set; }
        public virtual DbSet<tb_comunas> tb_comunas { get; set; }
        public virtual DbSet<tb_departamentos> tb_departamentos { get; set; }
        public virtual DbSet<tb_pantallas> tb_pantallas { get; set; }
        public virtual DbSet<tb_pantallasXroles> tb_pantallasXroles { get; set; }
        public virtual DbSet<tb_roles> tb_roles { get; set; }
        public virtual DbSet<tb_tramos> tb_tramos { get; set; }
        public virtual DbSet<tb_categorias> tb_categorias { get; set; }
        public virtual DbSet<tb_empleados> tb_empleados { get; set; }
        public virtual DbSet<tb_empleadosXusuarios> tb_empleadosXusuarios { get; set; }
        public virtual DbSet<tb_usuarios> tb_usuarios { get; set; }
        public virtual DbSet<tb_usuariosXroles> tb_usuariosXroles { get; set; }
    
        public virtual ObjectResult<string> PA_Activarciudades(string ciuid)
        {
            var ciuidParameter = ciuid != null ?
                new ObjectParameter("ciuid", ciuid) :
                new ObjectParameter("ciuid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_Activarciudades", ciuidParameter);
        }
    
        public virtual ObjectResult<string> PA_Activarcomunas(string comid)
        {
            var comidParameter = comid != null ?
                new ObjectParameter("comid", comid) :
                new ObjectParameter("comid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_Activarcomunas", comidParameter);
        }
    
        public virtual ObjectResult<string> PA_ActivarUsuario(string usuid)
        {
            var usuidParameter = usuid != null ?
                new ObjectParameter("usuid", usuid) :
                new ObjectParameter("usuid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_ActivarUsuario", usuidParameter);
        }
    
        public virtual ObjectResult<string> PA_Ciudades_Insertar(string ciuid, string ciudescripcion, string ciuusuariocrea, Nullable<System.DateTime> ciufechacrea, Nullable<bool> ciuestado)
        {
            var ciuidParameter = ciuid != null ?
                new ObjectParameter("ciuid", ciuid) :
                new ObjectParameter("ciuid", typeof(string));
    
            var ciudescripcionParameter = ciudescripcion != null ?
                new ObjectParameter("ciudescripcion", ciudescripcion) :
                new ObjectParameter("ciudescripcion", typeof(string));
    
            var ciuusuariocreaParameter = ciuusuariocrea != null ?
                new ObjectParameter("ciuusuariocrea", ciuusuariocrea) :
                new ObjectParameter("ciuusuariocrea", typeof(string));
    
            var ciufechacreaParameter = ciufechacrea.HasValue ?
                new ObjectParameter("ciufechacrea", ciufechacrea) :
                new ObjectParameter("ciufechacrea", typeof(System.DateTime));
    
            var ciuestadoParameter = ciuestado.HasValue ?
                new ObjectParameter("ciuestado", ciuestado) :
                new ObjectParameter("ciuestado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_Ciudades_Insertar", ciuidParameter, ciudescripcionParameter, ciuusuariocreaParameter, ciufechacreaParameter, ciuestadoParameter);
        }
    
        public virtual ObjectResult<string> PA_CiudadesUpdate(string ciuid, string ciudescripcion, string ciuusuariomodifica, Nullable<System.DateTime> ciufechamodifica)
        {
            var ciuidParameter = ciuid != null ?
                new ObjectParameter("ciuid", ciuid) :
                new ObjectParameter("ciuid", typeof(string));
    
            var ciudescripcionParameter = ciudescripcion != null ?
                new ObjectParameter("ciudescripcion", ciudescripcion) :
                new ObjectParameter("ciudescripcion", typeof(string));
    
            var ciuusuariomodificaParameter = ciuusuariomodifica != null ?
                new ObjectParameter("ciuusuariomodifica", ciuusuariomodifica) :
                new ObjectParameter("ciuusuariomodifica", typeof(string));
    
            var ciufechamodificaParameter = ciufechamodifica.HasValue ?
                new ObjectParameter("ciufechamodifica", ciufechamodifica) :
                new ObjectParameter("ciufechamodifica", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_CiudadesUpdate", ciuidParameter, ciudescripcionParameter, ciuusuariomodificaParameter, ciufechamodificaParameter);
        }
    
        public virtual ObjectResult<string> PA_Comunas_Insertar(string comid, string comdescripcion, string comkmi, Nullable<System.DateTime> comkmf, Nullable<bool> comestado, string comusuariocrea, Nullable<System.DateTime> comfechacrea)
        {
            var comidParameter = comid != null ?
                new ObjectParameter("comid", comid) :
                new ObjectParameter("comid", typeof(string));
    
            var comdescripcionParameter = comdescripcion != null ?
                new ObjectParameter("comdescripcion", comdescripcion) :
                new ObjectParameter("comdescripcion", typeof(string));
    
            var comkmiParameter = comkmi != null ?
                new ObjectParameter("comkmi", comkmi) :
                new ObjectParameter("comkmi", typeof(string));
    
            var comkmfParameter = comkmf.HasValue ?
                new ObjectParameter("comkmf", comkmf) :
                new ObjectParameter("comkmf", typeof(System.DateTime));
    
            var comestadoParameter = comestado.HasValue ?
                new ObjectParameter("comestado", comestado) :
                new ObjectParameter("comestado", typeof(bool));
    
            var comusuariocreaParameter = comusuariocrea != null ?
                new ObjectParameter("comusuariocrea", comusuariocrea) :
                new ObjectParameter("comusuariocrea", typeof(string));
    
            var comfechacreaParameter = comfechacrea.HasValue ?
                new ObjectParameter("comfechacrea", comfechacrea) :
                new ObjectParameter("comfechacrea", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_Comunas_Insertar", comidParameter, comdescripcionParameter, comkmiParameter, comkmfParameter, comestadoParameter, comusuariocreaParameter, comfechacreaParameter);
        }
    
        public virtual ObjectResult<string> PA_ComunasUpdate(string comid, string comdescripcion, string comkmi, Nullable<System.DateTime> comkmf, Nullable<bool> comestado, string comusuariomodifica, Nullable<System.DateTime> comfechamodifica)
        {
            var comidParameter = comid != null ?
                new ObjectParameter("comid", comid) :
                new ObjectParameter("comid", typeof(string));
    
            var comdescripcionParameter = comdescripcion != null ?
                new ObjectParameter("comdescripcion", comdescripcion) :
                new ObjectParameter("comdescripcion", typeof(string));
    
            var comkmiParameter = comkmi != null ?
                new ObjectParameter("comkmi", comkmi) :
                new ObjectParameter("comkmi", typeof(string));
    
            var comkmfParameter = comkmf.HasValue ?
                new ObjectParameter("comkmf", comkmf) :
                new ObjectParameter("comkmf", typeof(System.DateTime));
    
            var comestadoParameter = comestado.HasValue ?
                new ObjectParameter("comestado", comestado) :
                new ObjectParameter("comestado", typeof(bool));
    
            var comusuariomodificaParameter = comusuariomodifica != null ?
                new ObjectParameter("comusuariomodifica", comusuariomodifica) :
                new ObjectParameter("comusuariomodifica", typeof(string));
    
            var comfechamodificaParameter = comfechamodifica.HasValue ?
                new ObjectParameter("comfechamodifica", comfechamodifica) :
                new ObjectParameter("comfechamodifica", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_ComunasUpdate", comidParameter, comdescripcionParameter, comkmiParameter, comkmfParameter, comestadoParameter, comusuariomodificaParameter, comfechamodificaParameter);
        }
    
        public virtual ObjectResult<string> PA_InactivarCiudades(string ciuid)
        {
            var ciuidParameter = ciuid != null ?
                new ObjectParameter("ciuid", ciuid) :
                new ObjectParameter("ciuid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_InactivarCiudades", ciuidParameter);
        }
    
        public virtual ObjectResult<string> PA_Inactivarcomunas(string comid)
        {
            var comidParameter = comid != null ?
                new ObjectParameter("comid", comid) :
                new ObjectParameter("comid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_Inactivarcomunas", comidParameter);
        }
    
        public virtual ObjectResult<string> PA_InactivarUsuario(string usuid)
        {
            var usuidParameter = usuid != null ?
                new ObjectParameter("usuid", usuid) :
                new ObjectParameter("usuid", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_InactivarUsuario", usuidParameter);
        }
    
        public virtual ObjectResult<string> PA_Usario_Insertar(string usuid, string usudescripcion, string usupassword, string usuusuariocrea, Nullable<System.DateTime> usufechacrea, Nullable<bool> usuestado)
        {
            var usuidParameter = usuid != null ?
                new ObjectParameter("usuid", usuid) :
                new ObjectParameter("usuid", typeof(string));
    
            var usudescripcionParameter = usudescripcion != null ?
                new ObjectParameter("usudescripcion", usudescripcion) :
                new ObjectParameter("usudescripcion", typeof(string));
    
            var usupasswordParameter = usupassword != null ?
                new ObjectParameter("usupassword", usupassword) :
                new ObjectParameter("usupassword", typeof(string));
    
            var usuusuariocreaParameter = usuusuariocrea != null ?
                new ObjectParameter("usuusuariocrea", usuusuariocrea) :
                new ObjectParameter("usuusuariocrea", typeof(string));
    
            var usufechacreaParameter = usufechacrea.HasValue ?
                new ObjectParameter("usufechacrea", usufechacrea) :
                new ObjectParameter("usufechacrea", typeof(System.DateTime));
    
            var usuestadoParameter = usuestado.HasValue ?
                new ObjectParameter("usuestado", usuestado) :
                new ObjectParameter("usuestado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_Usario_Insertar", usuidParameter, usudescripcionParameter, usupasswordParameter, usuusuariocreaParameter, usufechacreaParameter, usuestadoParameter);
        }
    
        public virtual ObjectResult<string> PA_UsuarioUpdate(string usuid, string usudescripcion, string usupassword, string usuusuariocrea, Nullable<System.DateTime> usufechacrea, Nullable<bool> usuestado)
        {
            var usuidParameter = usuid != null ?
                new ObjectParameter("usuid", usuid) :
                new ObjectParameter("usuid", typeof(string));
    
            var usudescripcionParameter = usudescripcion != null ?
                new ObjectParameter("usudescripcion", usudescripcion) :
                new ObjectParameter("usudescripcion", typeof(string));
    
            var usupasswordParameter = usupassword != null ?
                new ObjectParameter("usupassword", usupassword) :
                new ObjectParameter("usupassword", typeof(string));
    
            var usuusuariocreaParameter = usuusuariocrea != null ?
                new ObjectParameter("usuusuariocrea", usuusuariocrea) :
                new ObjectParameter("usuusuariocrea", typeof(string));
    
            var usufechacreaParameter = usufechacrea.HasValue ?
                new ObjectParameter("usufechacrea", usufechacrea) :
                new ObjectParameter("usufechacrea", typeof(System.DateTime));
    
            var usuestadoParameter = usuestado.HasValue ?
                new ObjectParameter("usuestado", usuestado) :
                new ObjectParameter("usuestado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_UsuarioUpdate", usuidParameter, usudescripcionParameter, usupasswordParameter, usuusuariocreaParameter, usufechacreaParameter, usuestadoParameter);
        }
    
        public virtual ObjectResult<string> PA_ACTIVAR_TB_ROLES(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_ACTIVAR_TB_ROLES", idParameter);
        }
    
        public virtual ObjectResult<string> PA_ACTIVAR_TB_TRAMOS(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_ACTIVAR_TB_TRAMOS", idParameter);
        }
    
        public virtual ObjectResult<string> PA_INACTIVAR_TB_ROLES(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_INACTIVAR_TB_ROLES", idParameter);
        }
    
        public virtual ObjectResult<string> PA_INACTIVAR_TB_TRAMOS(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_INACTIVAR_TB_TRAMOS", idParameter);
        }
    
        public virtual ObjectResult<string> PA_INSERT_TB_ROLES(string descripcion, string usuario_crea)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var usuario_creaParameter = usuario_crea != null ?
                new ObjectParameter("usuario_crea", usuario_crea) :
                new ObjectParameter("usuario_crea", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_INSERT_TB_ROLES", descripcionParameter, usuario_creaParameter);
        }
    
        public virtual ObjectResult<string> PA_INSERT_TB_TRAMOS(string descripcion, string km_inicio, string km_fin, string car_id, string usuario_crea)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var km_inicioParameter = km_inicio != null ?
                new ObjectParameter("km_inicio", km_inicio) :
                new ObjectParameter("km_inicio", typeof(string));
    
            var km_finParameter = km_fin != null ?
                new ObjectParameter("km_fin", km_fin) :
                new ObjectParameter("km_fin", typeof(string));
    
            var car_idParameter = car_id != null ?
                new ObjectParameter("car_id", car_id) :
                new ObjectParameter("car_id", typeof(string));
    
            var usuario_creaParameter = usuario_crea != null ?
                new ObjectParameter("usuario_crea", usuario_crea) :
                new ObjectParameter("usuario_crea", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_INSERT_TB_TRAMOS", descripcionParameter, km_inicioParameter, km_finParameter, car_idParameter, usuario_creaParameter);
        }
    
        public virtual ObjectResult<string> PA_UPDATE_TB_ROLES(string id, string descripcion, string usuario_modifica)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var usuario_modificaParameter = usuario_modifica != null ?
                new ObjectParameter("usuario_modifica", usuario_modifica) :
                new ObjectParameter("usuario_modifica", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_UPDATE_TB_ROLES", idParameter, descripcionParameter, usuario_modificaParameter);
        }
    
        public virtual ObjectResult<string> PA_UPDATE_TB_TRAMOS(string id, string descripcion, string km_inicio, string km_fin, string car_id, string usuario_modifica)
        {
            var idParameter = id != null ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("descripcion", descripcion) :
                new ObjectParameter("descripcion", typeof(string));
    
            var km_inicioParameter = km_inicio != null ?
                new ObjectParameter("km_inicio", km_inicio) :
                new ObjectParameter("km_inicio", typeof(string));
    
            var km_finParameter = km_fin != null ?
                new ObjectParameter("km_fin", km_fin) :
                new ObjectParameter("km_fin", typeof(string));
    
            var car_idParameter = car_id != null ?
                new ObjectParameter("car_id", car_id) :
                new ObjectParameter("car_id", typeof(string));
    
            var usuario_modificaParameter = usuario_modifica != null ?
                new ObjectParameter("usuario_modifica", usuario_modifica) :
                new ObjectParameter("usuario_modifica", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_UPDATE_TB_TRAMOS", idParameter, descripcionParameter, km_inicioParameter, km_finParameter, car_idParameter, usuario_modificaParameter);
        }
    
        public virtual ObjectResult<string> PA_ACTIVARCATEGORIAS(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_ACTIVARCATEGORIAS", idParameter);
        }
    
        public virtual ObjectResult<string> PA_INACTIVARCATEGORIAS(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_INACTIVARCATEGORIAS", idParameter);
        }
    
        public virtual ObjectResult<string> PA_INSERTCATEGORIAS(string id, string descripcion, string usuarioCrea, Nullable<System.DateTime> fechaCrea)
        {
            var idParameter = id != null ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var usuarioCreaParameter = usuarioCrea != null ?
                new ObjectParameter("UsuarioCrea", usuarioCrea) :
                new ObjectParameter("UsuarioCrea", typeof(string));
    
            var fechaCreaParameter = fechaCrea.HasValue ?
                new ObjectParameter("FechaCrea", fechaCrea) :
                new ObjectParameter("FechaCrea", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_INSERTCATEGORIAS", idParameter, descripcionParameter, usuarioCreaParameter, fechaCreaParameter);
        }
    
        public virtual ObjectResult<string> PA_UPDATECATEGORIAS(string id, string descripcion, string usuarioModifica, Nullable<System.DateTime> fechamodifica, Nullable<bool> estado)
        {
            var idParameter = id != null ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var usuarioModificaParameter = usuarioModifica != null ?
                new ObjectParameter("UsuarioModifica", usuarioModifica) :
                new ObjectParameter("UsuarioModifica", typeof(string));
    
            var fechamodificaParameter = fechamodifica.HasValue ?
                new ObjectParameter("Fechamodifica", fechamodifica) :
                new ObjectParameter("Fechamodifica", typeof(System.DateTime));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_UPDATECATEGORIAS", idParameter, descripcionParameter, usuarioModificaParameter, fechamodificaParameter, estadoParameter);
        }
    
        public virtual ObjectResult<string> PA_ACTIVAREMPLEADOS(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_ACTIVAREMPLEADOS", idParameter);
        }
    
        public virtual ObjectResult<string> PA_INACTIVAREMPLEADOS(string id)
        {
            var idParameter = id != null ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_INACTIVAREMPLEADOS", idParameter);
        }
    
        public virtual ObjectResult<string> PA_INSERTEMPLEADOS(string id, string nombre, Nullable<int> edad, string telefono, string ciu_id, string usuarioCrea, Nullable<System.DateTime> fechaCrea)
        {
            var idParameter = id != null ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var edadParameter = edad.HasValue ?
                new ObjectParameter("Edad", edad) :
                new ObjectParameter("Edad", typeof(int));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var ciu_idParameter = ciu_id != null ?
                new ObjectParameter("ciu_id", ciu_id) :
                new ObjectParameter("ciu_id", typeof(string));
    
            var usuarioCreaParameter = usuarioCrea != null ?
                new ObjectParameter("UsuarioCrea", usuarioCrea) :
                new ObjectParameter("UsuarioCrea", typeof(string));
    
            var fechaCreaParameter = fechaCrea.HasValue ?
                new ObjectParameter("FechaCrea", fechaCrea) :
                new ObjectParameter("FechaCrea", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_INSERTEMPLEADOS", idParameter, nombreParameter, edadParameter, telefonoParameter, ciu_idParameter, usuarioCreaParameter, fechaCreaParameter);
        }
    
        public virtual ObjectResult<string> PA_UPDATEEMPLEADOS(string id, string nombre, Nullable<int> edad, string telefono, string ciu_id, string usuarioModifica, Nullable<System.DateTime> fechamodifica, Nullable<bool> estado)
        {
            var idParameter = id != null ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var edadParameter = edad.HasValue ?
                new ObjectParameter("Edad", edad) :
                new ObjectParameter("Edad", typeof(int));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("telefono", telefono) :
                new ObjectParameter("telefono", typeof(string));
    
            var ciu_idParameter = ciu_id != null ?
                new ObjectParameter("ciu_id", ciu_id) :
                new ObjectParameter("ciu_id", typeof(string));
    
            var usuarioModificaParameter = usuarioModifica != null ?
                new ObjectParameter("UsuarioModifica", usuarioModifica) :
                new ObjectParameter("UsuarioModifica", typeof(string));
    
            var fechamodificaParameter = fechamodifica.HasValue ?
                new ObjectParameter("Fechamodifica", fechamodifica) :
                new ObjectParameter("Fechamodifica", typeof(System.DateTime));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("PA_UPDATEEMPLEADOS", idParameter, nombreParameter, edadParameter, telefonoParameter, ciu_idParameter, usuarioModificaParameter, fechamodificaParameter, estadoParameter);
        }
    }
}
