
namespace SolicitudesAppWindows
{
    partial class Garantia01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgGarantia = new System.Windows.Forms.DataGridView();
            this.Id_garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip_garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des_garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_garantia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblRegistros = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGarantia)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGarantia
            // 
            this.dtgGarantia.AllowUserToAddRows = false;
            this.dtgGarantia.AllowUserToDeleteRows = false;
            this.dtgGarantia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgGarantia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgGarantia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGarantia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_garantia,
            this.nomCliente,
            this.apeCliente,
            this.Id_cli,
            this.Tip_garantia,
            this.Des_garantia,
            this.Valor_garantia,
            this.Estado});
            this.dtgGarantia.Location = new System.Drawing.Point(29, 36);
            this.dtgGarantia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgGarantia.Name = "dtgGarantia";
            this.dtgGarantia.ReadOnly = true;
            this.dtgGarantia.RowHeadersVisible = false;
            this.dtgGarantia.RowHeadersWidth = 51;
            this.dtgGarantia.RowTemplate.Height = 24;
            this.dtgGarantia.Size = new System.Drawing.Size(1275, 447);
            this.dtgGarantia.TabIndex = 1;
            // 
            // Id_garantia
            // 
            this.Id_garantia.DataPropertyName = "Id_garantia";
            this.Id_garantia.HeaderText = "Codigo";
            this.Id_garantia.MinimumWidth = 6;
            this.Id_garantia.Name = "Id_garantia";
            this.Id_garantia.ReadOnly = true;
            // 
            // nomCliente
            // 
            this.nomCliente.DataPropertyName = "nomCliente";
            this.nomCliente.HeaderText = "Nombre Cliente";
            this.nomCliente.MinimumWidth = 6;
            this.nomCliente.Name = "nomCliente";
            this.nomCliente.ReadOnly = true;
            // 
            // apeCliente
            // 
            this.apeCliente.DataPropertyName = "apeCliente";
            this.apeCliente.HeaderText = "Apellido Cliente";
            this.apeCliente.MinimumWidth = 6;
            this.apeCliente.Name = "apeCliente";
            this.apeCliente.ReadOnly = true;
            // 
            // Id_cli
            // 
            this.Id_cli.DataPropertyName = "Id_cli";
            this.Id_cli.HeaderText = "Cod Cliente";
            this.Id_cli.MinimumWidth = 6;
            this.Id_cli.Name = "Id_cli";
            this.Id_cli.ReadOnly = true;
            // 
            // Tip_garantia
            // 
            this.Tip_garantia.DataPropertyName = "Tip_garantia";
            this.Tip_garantia.HeaderText = "Tipo";
            this.Tip_garantia.MinimumWidth = 6;
            this.Tip_garantia.Name = "Tip_garantia";
            this.Tip_garantia.ReadOnly = true;
            // 
            // Des_garantia
            // 
            this.Des_garantia.DataPropertyName = "Des_garantia";
            this.Des_garantia.HeaderText = "Descripcion";
            this.Des_garantia.MinimumWidth = 6;
            this.Des_garantia.Name = "Des_garantia";
            this.Des_garantia.ReadOnly = true;
            // 
            // Valor_garantia
            // 
            this.Valor_garantia.DataPropertyName = "Valor_garantia";
            this.Valor_garantia.HeaderText = "Valor";
            this.Valor_garantia.MinimumWidth = 6;
            this.Valor_garantia.Name = "Valor_garantia";
            this.Valor_garantia.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(1090, 562);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(214, 40);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(868, 562);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(213, 40);
            this.btnActualizar.TabIndex = 7;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Location = new System.Drawing.Point(645, 562);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(214, 40);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // lblRegistros
            // 
            this.lblRegistros.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistros.Location = new System.Drawing.Point(1189, 503);
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(114, 41);
            this.lblRegistros.TabIndex = 10;
            this.lblRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1112, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registros:";
            // 
            // Garantia01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 615);
            this.Controls.Add(this.lblRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.dtgGarantia);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Garantia01";
            this.Text = "Garantia";
            this.Load += new System.EventHandler(this.Garantia01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGarantia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgGarantia;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Label lblRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_garantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip_garantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Des_garantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_garantia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}

