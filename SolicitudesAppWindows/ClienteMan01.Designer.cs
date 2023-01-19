
namespace SolicitudesAppWindows
{
    partial class ClienteMan01
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
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.Id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruc_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstCivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel_educacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_cliente,
            this.Nom_cli,
            this.Ape_cli,
            this.Dni_cli,
            this.Ruc_cli,
            this.Sexo,
            this.Edad,
            this.EstCivil,
            this.Nivel_educacion,
            this.Email,
            this.Estado});
            this.dtgCliente.Location = new System.Drawing.Point(12, 12);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            this.dtgCliente.RowHeadersVisible = false;
            this.dtgCliente.RowHeadersWidth = 51;
            this.dtgCliente.RowTemplate.Height = 24;
            this.dtgCliente.Size = new System.Drawing.Size(1185, 451);
            this.dtgCliente.TabIndex = 0;
            // 
            // Id_cliente
            // 
            this.Id_cliente.DataPropertyName = "Id_cliente";
            this.Id_cliente.HeaderText = "Codigo";
            this.Id_cliente.MinimumWidth = 6;
            this.Id_cliente.Name = "Id_cliente";
            this.Id_cliente.ReadOnly = true;
            // 
            // Nom_cli
            // 
            this.Nom_cli.DataPropertyName = "Nom_cli";
            this.Nom_cli.HeaderText = "Nombre";
            this.Nom_cli.MinimumWidth = 6;
            this.Nom_cli.Name = "Nom_cli";
            this.Nom_cli.ReadOnly = true;
            // 
            // Ape_cli
            // 
            this.Ape_cli.DataPropertyName = "Ape_cli";
            this.Ape_cli.HeaderText = "Apellido";
            this.Ape_cli.MinimumWidth = 6;
            this.Ape_cli.Name = "Ape_cli";
            this.Ape_cli.ReadOnly = true;
            // 
            // Dni_cli
            // 
            this.Dni_cli.DataPropertyName = "Dni_cli";
            this.Dni_cli.HeaderText = "DNI";
            this.Dni_cli.MinimumWidth = 6;
            this.Dni_cli.Name = "Dni_cli";
            this.Dni_cli.ReadOnly = true;
            // 
            // Ruc_cli
            // 
            this.Ruc_cli.DataPropertyName = "Ruc_cli";
            this.Ruc_cli.HeaderText = "RUC";
            this.Ruc_cli.MinimumWidth = 6;
            this.Ruc_cli.Name = "Ruc_cli";
            this.Ruc_cli.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.DataPropertyName = "Edad";
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // EstCivil
            // 
            this.EstCivil.DataPropertyName = "EstCivil";
            this.EstCivil.HeaderText = "Est. Civil";
            this.EstCivil.MinimumWidth = 6;
            this.EstCivil.Name = "EstCivil";
            this.EstCivil.ReadOnly = true;
            // 
            // Nivel_educacion
            // 
            this.Nivel_educacion.DataPropertyName = "Nivel_educacion";
            this.Nivel_educacion.HeaderText = "Estudios";
            this.Nivel_educacion.MinimumWidth = 6;
            this.Nivel_educacion.Name = "Nivel_educacion";
            this.Nivel_educacion.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "E-mail";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(985, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(1063, 478);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(114, 41);
            this.lblRegistros.TabIndex = 2;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(618, 537);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(180, 36);
            this.btnInsertar.TabIndex = 3;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(809, 537);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(179, 37);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(999, 537);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 36);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ClienteMan01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 585);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgCliente);
            this.Name = "ClienteMan01";
            this.Text = "Mantenimiento de Clientes";
            this.Load += new System.EventHandler(this.ClienteMan01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ape_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruc_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstCivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel_educacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}

