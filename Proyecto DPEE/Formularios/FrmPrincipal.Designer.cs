
namespace Proyecto_DPEE
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAutentificacion = new System.Windows.Forms.ToolStripTextBox();
            this.MnuNotificaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuTickect = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuReporteria = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteEnLíneaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAdministracion = new System.Windows.Forms.ToolStripMenuItem();
            this.dispositivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.señalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.áreasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.servidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebaDeComunicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tickectsPorFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.configuraciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.Size = new System.Drawing.Size(1041, 24);
            this.MnuPrincipal.TabIndex = 0;
            this.MnuPrincipal.Text = "menuStrip1";
            this.MnuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAutentificacion,
            this.MnuNotificaciones,
            this.MnuTickect,
            this.MnuReporteria,
            this.MnuAdministracion});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 20);
            this.toolStripMenuItem1.Text = "Menú Principal";
            // 
            // MnuAutentificacion
            // 
            this.MnuAutentificacion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MnuAutentificacion.Name = "MnuAutentificacion";
            this.MnuAutentificacion.Size = new System.Drawing.Size(100, 23);
            this.MnuAutentificacion.Text = "Autentificación";
            this.MnuAutentificacion.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            // 
            // MnuNotificaciones
            // 
            this.MnuNotificaciones.Name = "MnuNotificaciones";
            this.MnuNotificaciones.Size = new System.Drawing.Size(180, 22);
            this.MnuNotificaciones.Text = "Notificaciones";
            // 
            // MnuTickect
            // 
            this.MnuTickect.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem,
            this.cancelaciónToolStripMenuItem});
            this.MnuTickect.Name = "MnuTickect";
            this.MnuTickect.Size = new System.Drawing.Size(180, 22);
            this.MnuTickect.Text = "Tickets";
            // 
            // MnuReporteria
            // 
            this.MnuReporteria.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDiarioToolStripMenuItem,
            this.reporteEnLíneaToolStripMenuItem,
            this.tickectsPorFechasToolStripMenuItem});
            this.MnuReporteria.Name = "MnuReporteria";
            this.MnuReporteria.Size = new System.Drawing.Size(180, 22);
            this.MnuReporteria.Text = "Reportería";
            // 
            // reporteDiarioToolStripMenuItem
            // 
            this.reporteDiarioToolStripMenuItem.Name = "reporteDiarioToolStripMenuItem";
            this.reporteDiarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteDiarioToolStripMenuItem.Text = "Reporte Diario";
            // 
            // reporteEnLíneaToolStripMenuItem
            // 
            this.reporteEnLíneaToolStripMenuItem.Name = "reporteEnLíneaToolStripMenuItem";
            this.reporteEnLíneaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reporteEnLíneaToolStripMenuItem.Text = "Reporte en Línea";
            // 
            // MnuAdministracion
            // 
            this.MnuAdministracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dispositivosToolStripMenuItem,
            this.plantillasToolStripMenuItem,
            this.unidadesToolStripMenuItem,
            this.señalesToolStripMenuItem,
            this.turnosToolStripMenuItem,
            this.áreasToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.permisosToolStripMenuItem,
            this.rolesToolStripMenuItem});
            this.MnuAdministracion.Name = "MnuAdministracion";
            this.MnuAdministracion.Size = new System.Drawing.Size(180, 22);
            this.MnuAdministracion.Text = "Administración";
            // 
            // dispositivosToolStripMenuItem
            // 
            this.dispositivosToolStripMenuItem.Name = "dispositivosToolStripMenuItem";
            this.dispositivosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dispositivosToolStripMenuItem.Text = "Dispositivos";
            // 
            // plantillasToolStripMenuItem
            // 
            this.plantillasToolStripMenuItem.Name = "plantillasToolStripMenuItem";
            this.plantillasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.plantillasToolStripMenuItem.Text = "Plantillas";
            // 
            // unidadesToolStripMenuItem
            // 
            this.unidadesToolStripMenuItem.Name = "unidadesToolStripMenuItem";
            this.unidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unidadesToolStripMenuItem.Text = "Unidades";
            // 
            // señalesToolStripMenuItem
            // 
            this.señalesToolStripMenuItem.Name = "señalesToolStripMenuItem";
            this.señalesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.señalesToolStripMenuItem.Text = "Señales";
            // 
            // turnosToolStripMenuItem
            // 
            this.turnosToolStripMenuItem.Name = "turnosToolStripMenuItem";
            this.turnosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.turnosToolStripMenuItem.Text = "Turnos";
            // 
            // áreasToolStripMenuItem
            // 
            this.áreasToolStripMenuItem.Name = "áreasToolStripMenuItem";
            this.áreasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.áreasToolStripMenuItem.Text = "Áreas";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.permisosToolStripMenuItem.Text = "Permisos";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.servidorToolStripMenuItem,
            this.pruebaDeComunicaciónToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // servidorToolStripMenuItem
            // 
            this.servidorToolStripMenuItem.Name = "servidorToolStripMenuItem";
            this.servidorToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.servidorToolStripMenuItem.Text = "Servidor";
            // 
            // pruebaDeComunicaciónToolStripMenuItem
            // 
            this.pruebaDeComunicaciónToolStripMenuItem.Name = "pruebaDeComunicaciónToolStripMenuItem";
            this.pruebaDeComunicaciónToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.pruebaDeComunicaciónToolStripMenuItem.Text = "Prueba de Comunicación";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.altasToolStripMenuItem.Text = "Altas/Baja/Cambios";
            // 
            // cancelaciónToolStripMenuItem
            // 
            this.cancelaciónToolStripMenuItem.Name = "cancelaciónToolStripMenuItem";
            this.cancelaciónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cancelaciónToolStripMenuItem.Text = "Cancelación";
            // 
            // tickectsPorFechasToolStripMenuItem
            // 
            this.tickectsPorFechasToolStripMenuItem.Name = "tickectsPorFechasToolStripMenuItem";
            this.tickectsPorFechasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tickectsPorFechasToolStripMenuItem.Text = "Tickects por Fechas";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 569);
            this.Controls.Add(this.MnuPrincipal);
            this.MainMenuStrip = this.MnuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto DPEE";
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MnuNotificaciones;
        private System.Windows.Forms.ToolStripMenuItem MnuTickect;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem servidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox MnuAutentificacion;
        private System.Windows.Forms.ToolStripMenuItem MnuReporteria;
        private System.Windows.Forms.ToolStripMenuItem reporteDiarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteEnLíneaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuAdministracion;
        private System.Windows.Forms.ToolStripMenuItem dispositivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plantillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem señalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem áreasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pruebaDeComunicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tickectsPorFechasToolStripMenuItem;
    }
}

