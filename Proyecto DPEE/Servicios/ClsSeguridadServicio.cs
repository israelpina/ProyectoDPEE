using System.Data;
using System.Linq;

using Proyecto_DPEE.Utilerias;

namespace Proyecto_DPEE.Servicios
{
    public class ClsSeguridadServicio : ClsBaseServicio
    {

        public ClsSeguridadServicio() : base() { }

        public bool Login(string usuario, string contrasena)
        {
            bool retorno = false;
            InicializaCommand("SP_SEG_Login");

            _SqlCommand.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuario;
            _SqlCommand.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = contrasena;

            if (GetData())
            {
                // OPCION 1: MANEJO DIRECTO DEL DATATABLE
                //ClsSeguridad.UsuarioLogeado user = new ClsSeguridad.UsuarioLogeado()
                //{
                //    IdUsuario = DtResultados.Rows[0].Field<int>("IdUsuario"),
                //    Usuario = DtResultados.Rows[0].Field<string>("Usuario"),
                //    NombreCompleto = DtResultados.Rows[0].Field<string>("NombreCompleto"),
                //    CorreoElectronico = DtResultados.Rows[0].Field<string>("CorreoElectronico"),
                //};
                //ClsSeguridad._UsuarioActual = user;

                // OPCION 2: MANEJO POR MEDIO DE LAMBDA EXPRESIONS
                ClsSeguridad._UsuarioActual = DtResultados.AsEnumerable().Select(s => new ClsSeguridad.UsuarioLogeado()
                {
                    IdUsuario = s["IdUsuario"].ToString().ToInteger(),
                    Usuario = s["Usuario"].ToString(),
                    NombreCompleto = s["NombreCompleto"].ToString(),
                    CorreoElectronico = s["CorreoElectronico"].ToString()
                }).First();
                retorno = true;
            }

            return retorno;
        }

    }
}
