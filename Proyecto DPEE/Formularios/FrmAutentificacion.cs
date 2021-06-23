using System;
using System.Windows.Forms;

using Proyecto_DPEE.Servicios;
using Proyecto_DPEE.Utilerias;

namespace Proyecto_DPEE
{
    public partial class FrmAutentificacion : Form
    {

        ClsSeguridadServicio _Servicio = new ClsSeguridadServicio();

        public FrmAutentificacion()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            // VARIABLES
            string Usuario = TxtUsuario.Text;
            string Contrasena = TxtContraseña.Text;

            // VALIDACIONES
            if (Usuario.IsNullOrEmpty())
            {
                MessageBox.Show("El campo USUARIO es obligatorio");
                return;
            }

            if (Contrasena.IsNullOrEmpty())
            {
                MessageBox.Show("El campo CONTRASEÑA es obligatorio");
                return;
            }

            // CONSUMO DE LOGICA
            if (_Servicio.Login(Usuario, Contrasena))
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("KO");
            }
            _Servicio.Dispose();

        }

    }
}
