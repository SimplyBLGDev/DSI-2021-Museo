
namespace DSI2021.Frontend
{
    partial class PantallaRegistroVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTablaTarifas = new System.Windows.Forms.DataGridView();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoAdicionalGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantEntradas = new System.Windows.Forms.TextBox();
            this.lblEntradasEmitir = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.lblTextoDuracionVisita = new System.Windows.Forms.Label();
            this.lblDuracionVisita = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_sede = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaTarifas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sede)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvTablaTarifas);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarifas";
            // 
            // dgvTablaTarifas
            // 
            this.dgvTablaTarifas.AllowUserToAddRows = false;
            this.dgvTablaTarifas.AllowUserToDeleteRows = false;
            this.dgvTablaTarifas.AllowUserToResizeColumns = false;
            this.dgvTablaTarifas.AllowUserToResizeRows = false;
            this.dgvTablaTarifas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTablaTarifas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTablaTarifas.BackgroundColor = System.Drawing.Color.White;
            this.dgvTablaTarifas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTablaTarifas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTablaTarifas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTablaTarifas.ColumnHeadersHeight = 50;
            this.dgvTablaTarifas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTablaTarifas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Monto,
            this.MontoAdicionalGuia,
            this.TipoEntrada,
            this.TipoVisita});
            this.dgvTablaTarifas.EnableHeadersVisualStyles = false;
            this.dgvTablaTarifas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.dgvTablaTarifas.Location = new System.Drawing.Point(16, 26);
            this.dgvTablaTarifas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvTablaTarifas.MultiSelect = false;
            this.dgvTablaTarifas.Name = "dgvTablaTarifas";
            this.dgvTablaTarifas.ReadOnly = true;
            this.dgvTablaTarifas.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTablaTarifas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTablaTarifas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTablaTarifas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTablaTarifas.Size = new System.Drawing.Size(589, 238);
            this.dgvTablaTarifas.TabIndex = 44;
            this.dgvTablaTarifas.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaTarifas_RowEnter);
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // MontoAdicionalGuia
            // 
            this.MontoAdicionalGuia.HeaderText = "Monto Adicional Guia";
            this.MontoAdicionalGuia.Name = "MontoAdicionalGuia";
            this.MontoAdicionalGuia.ReadOnly = true;
            // 
            // TipoEntrada
            // 
            this.TipoEntrada.HeaderText = "Tipo de Entrada";
            this.TipoEntrada.Name = "TipoEntrada";
            this.TipoEntrada.ReadOnly = true;
            // 
            // TipoVisita
            // 
            this.TipoVisita.HeaderText = "Tipo de Visita";
            this.TipoVisita.Name = "TipoVisita";
            this.TipoVisita.ReadOnly = true;
            // 
            // txtCantEntradas
            // 
            this.txtCantEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCantEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantEntradas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantEntradas.Location = new System.Drawing.Point(32, 627);
            this.txtCantEntradas.Name = "txtCantEntradas";
            this.txtCantEntradas.Size = new System.Drawing.Size(145, 33);
            this.txtCantEntradas.TabIndex = 2;
            // 
            // lblEntradasEmitir
            // 
            this.lblEntradasEmitir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEntradasEmitir.AutoSize = true;
            this.lblEntradasEmitir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradasEmitir.Location = new System.Drawing.Point(27, 599);
            this.lblEntradasEmitir.Name = "lblEntradasEmitir";
            this.lblEntradasEmitir.Size = new System.Drawing.Size(158, 25);
            this.lblEntradasEmitir.TabIndex = 3;
            this.lblEntradasEmitir.Text = "Entradas a emitir:";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(500, 609);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 50);
            this.button5.TabIndex = 6;
            this.button5.Text = "Generar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnGenerar);
            // 
            // lblTextoDuracionVisita
            // 
            this.lblTextoDuracionVisita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTextoDuracionVisita.AutoSize = true;
            this.lblTextoDuracionVisita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoDuracionVisita.Location = new System.Drawing.Point(256, 17);
            this.lblTextoDuracionVisita.Name = "lblTextoDuracionVisita";
            this.lblTextoDuracionVisita.Size = new System.Drawing.Size(118, 21);
            this.lblTextoDuracionVisita.TabIndex = 7;
            this.lblTextoDuracionVisita.Text = "Duracion Visita:";
            this.lblTextoDuracionVisita.Visible = false;
            // 
            // lblDuracionVisita
            // 
            this.lblDuracionVisita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDuracionVisita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracionVisita.Location = new System.Drawing.Point(380, 17);
            this.lblDuracionVisita.Name = "lblDuracionVisita";
            this.lblDuracionVisita.Size = new System.Drawing.Size(79, 21);
            this.lblDuracionVisita.TabIndex = 8;
            this.lblDuracionVisita.Text = "0";
            this.lblDuracionVisita.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDuracionVisita.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_sede);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 282);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exposiciones";
            // 
            // dgv_sede
            // 
            this.dgv_sede.AllowUserToAddRows = false;
            this.dgv_sede.AllowUserToDeleteRows = false;
            this.dgv_sede.AllowUserToResizeColumns = false;
            this.dgv_sede.AllowUserToResizeRows = false;
            this.dgv_sede.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_sede.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sede.BackgroundColor = System.Drawing.Color.White;
            this.dgv_sede.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_sede.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sede.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_sede.ColumnHeadersHeight = 50;
            this.dgv_sede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_sede.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_sede.EnableHeadersVisualStyles = false;
            this.dgv_sede.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.dgv_sede.Location = new System.Drawing.Point(16, 26);
            this.dgv_sede.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_sede.MultiSelect = false;
            this.dgv_sede.Name = "dgv_sede";
            this.dgv_sede.ReadOnly = true;
            this.dgv_sede.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_sede.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_sede.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_sede.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sede.Size = new System.Drawing.Size(589, 248);
            this.dgv_sede.TabIndex = 44;
            this.dgv_sede.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SeleccionarExposicion);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Exposiciones";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Seleccionada";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PantallaRegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 689);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblDuracionVisita);
            this.Controls.Add(this.lblTextoDuracionVisita);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblEntradasEmitir);
            this.Controls.Add(this.txtCantEntradas);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PantallaRegistroVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaRegistroVenta";
            this.Load += new System.EventHandler(this.PantallaRegistroVenta_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaTarifas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sede)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantEntradas;
        private System.Windows.Forms.Label lblEntradasEmitir;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dgvTablaTarifas;
		private System.Windows.Forms.Label lblTextoDuracionVisita;
		private System.Windows.Forms.Label lblDuracionVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoAdicionalGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVisita;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_sede;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewTextBoxColumn2;
    }
}