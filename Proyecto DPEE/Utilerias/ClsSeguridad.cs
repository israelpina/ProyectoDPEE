using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_DPEE.Utilerias
{
    public static class ClsSeguridad
    {

        public static UsuarioLogeado _UsuarioActual { get; set; }


        public class UsuarioLogeado
        {
            public int IdUsuario { get; set; }
            public string Usuario { get; set; }
            public string NombreCompleto { get; set; }
            public string CorreoElectronico { get; set; }
        }

    }
}
