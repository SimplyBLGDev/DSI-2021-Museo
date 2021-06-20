
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tablaTarifas = new System.Windows.Forms.DataGridView();
            this.txtCantEntradas = new System.Windows.Forms.TextBox();
            this.lblEntradasEmitir = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDuracionVisita = new System.Windows.Forms.Label();
            this.TipoVisita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoAdicionalGuia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Location = new System.Drawing.Point(29, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tarifas";
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
            this.Monto,
            this.MontoAdicionalGuia,
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
            this.tablaTarifas.Size = new System.Drawing.Size(589, 326);
            this.tablaTarifas.TabIndex = 44;
            // 
            // txtCantEntradas
            // 
            this.txtCantEntradas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCantEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantEntradas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantEntradas.Location = new System.Drawing.Point(32, 437);
            this.txtCantEntradas.Name = "txtCantEntradas";
            this.txtCantEntradas.Size = new System.Drawing.Size(145, 33);
            this.txtCantEntradas.TabIndex = 2;
            // 
            // lblEntradasEmitir
            // 
            this.lblEntradasEmitir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEntradasEmitir.AutoSize = true;
            this.lblEntradasEmitir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntradasEmitir.Location = new System.Drawing.Point(27, 409);
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
            this.button5.Location = new System.Drawing.Point(500, 419);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 50);
            this.button5.TabIndex = 6;
            this.button5.Text = "Generar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnGenerar);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Duracion Visita:";
            // 
            // lblDuracionVisita
            // 
            this.lblDuracionVisita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDuracionVisita.AutoSize = true;
            this.lblDuracionVisita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuracionVisita.Location = new System.Drawing.Point(380, 17);
            this.lblDuracionVisita.Name = "lblDuracionVisita";
            this.lblDuracionVisita.Size = new System.Drawing.Size(19, 21);
            this.lblDuracionVisita.TabIndex = 8;
            this.lblDuracionVisita.Text = "0";
            this.lblDuracionVisita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TipoVisita
            // 
            this.TipoVisita.HeaderText = "Tipo de Visita";
            this.TipoVisita.Name = "TipoVisita";
            this.TipoVisita.ReadOnly = true;
            // 
            // TipoEntrada
            // 
            this.TipoEntrada.HeaderText = "Tipo de Entrada";
            this.TipoEntrada.Name = "TipoEntrada";
            this.TipoEntrada.ReadOnly = true;
            // 
            // MontoAdicionalGuia
            // 
            this.MontoAdicionalGuia.HeaderText = "Monto Adicional Guia";
            this.MontoAdicionalGuia.Name = "MontoAdicionalGuia";
            this.MontoAdicionalGuia.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // PantallaRegistroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(685, 499);
            this.Controls.Add(this.lblDuracionVisita);
            this.Controls.Add(this.label2);
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
            ((System.ComponentModel.ISupportInitialize)(this.tablaTarifas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantEntradas;
        private System.Windows.Forms.Label lblEntradasEmitir;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView tablaTarifas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblDuracionVisita;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoAdicionalGuia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVisita;
    }
}