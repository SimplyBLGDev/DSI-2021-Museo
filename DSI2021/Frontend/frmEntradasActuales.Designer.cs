
namespace DSI2021.Frontend
{
    partial class frmEntradasActuales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablaTarifas = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTexCupoMaximo = new System.Windows.Forms.Label();
            this.lblTexCupoActual = new System.Windows.Forms.Label();
            this.lblCupoMaximo = new System.Windows.Forms.Label();
            this.lblCupoActual = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaTarifas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tablaTarifas);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 480);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entradas Actuales";
            // 
            // tablaTarifas
            // 
            this.tablaTarifas.AllowUserToAddRows = false;
            this.tablaTarifas.AllowUserToDeleteRows = false;
            this.tablaTarifas.AllowUserToResizeColumns = false;
            this.tablaTarifas.AllowUserToResizeRows = false;
            this.tablaTarifas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaTarifas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaTarifas.BackgroundColor = System.Drawing.Color.White;
            this.tablaTarifas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaTarifas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaTarifas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaTarifas.ColumnHeadersHeight = 50;
            this.tablaTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaTarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.HoraVenta,
            this.Monto,
            this.TipoEntrada,
            this.TipoVisita});
            this.tablaTarifas.EnableHeadersVisualStyles = false;
            this.tablaTarifas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.tablaTarifas.Location = new System.Drawing.Point(16, 26);
            this.tablaTarifas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaTarifas.MultiSelect = false;
            this.tablaTarifas.Name = "tablaTarifas";
            this.tablaTarifas.ReadOnly = true;
            this.tablaTarifas.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaTarifas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaTarifas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaTarifas.Size = new System.Drawing.Size(726, 438);
            this.tablaTarifas.TabIndex = 44;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // HoraVenta
            // 
            this.HoraVenta.HeaderText = "Hora Venta";
            this.HoraVenta.Name = "HoraVenta";
            this.HoraVenta.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // TipoEntrada
            // 
            this.TipoEntrada.HeaderText = "Tipo Entrada";
            this.TipoEntrada.Name = "TipoEntrada";
            this.TipoEntrada.ReadOnly = true;
            // 
            // TipoVisita
            // 
            this.TipoVisita.HeaderText = "Tipo Visita";
            this.TipoVisita.Name = "TipoVisita";
            this.TipoVisita.ReadOnly = true;
            // 
            // lblTexCupoMaximo
            // 
            this.lblTexCupoMaximo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTexCupoMaximo.AutoSize = true;
            this.lblTexCupoMaximo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexCupoMaximo.Location = new System.Drawing.Point(239, 21);
            this.lblTexCupoMaximo.Name = "lblTexCupoMaximo";
            this.lblTexCupoMaximo.Size = new System.Drawing.Size(110, 21);
            this.lblTexCupoMaximo.TabIndex = 4;
            this.lblTexCupoMaximo.Text = "Cupo Maximo:";
            // 
            // lblTexCupoActual
            // 
            this.lblTexCupoActual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTexCupoActual.AutoSize = true;
            this.lblTexCupoActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexCupoActual.Location = new System.Drawing.Point(425, 21);
            this.lblTexCupoActual.Name = "lblTexCupoActual";
            this.lblTexCupoActual.Size = new System.Drawing.Size(97, 21);
            this.lblTexCupoActual.TabIndex = 5;
            this.lblTexCupoActual.Text = "Cupo Actual:";
            // 
            // lblCupoMaximo
            // 
            this.lblCupoMaximo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCupoMaximo.AutoSize = true;
            this.lblCupoMaximo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupoMaximo.Location = new System.Drawing.Point(355, 21);
            this.lblCupoMaximo.Name = "lblCupoMaximo";
            this.lblCupoMaximo.Size = new System.Drawing.Size(37, 21);
            this.lblCupoMaximo.TabIndex = 6;
            this.lblCupoMaximo.Text = "300";
            // 
            // lblCupoActual
            // 
            this.lblCupoActual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCupoActual.AutoSize = true;
            this.lblCupoActual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCupoActual.Location = new System.Drawing.Point(518, 21);
            this.lblCupoActual.Name = "lblCupoActual";
            this.lblCupoActual.Size = new System.Drawing.Size(28, 21);
            this.lblCupoActual.TabIndex = 7;
            this.lblCupoActual.Text = "43";
            // 
            // frmEntradasActuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 543);
            this.Controls.Add(this.lblCupoActual);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTexCupoActual);
            this.Controls.Add(this.lblCupoMaximo);
            this.Controls.Add(this.lblTexCupoMaximo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEntradasActuales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEntradasActuales";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaTarifas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tablaTarifas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVisita;
        private System.Windows.Forms.Label lblTexCupoMaximo;
        private System.Windows.Forms.Label lblTexCupoActual;
        private System.Windows.Forms.Label lblCupoMaximo;
        private System.Windows.Forms.Label lblCupoActual;
    }
}