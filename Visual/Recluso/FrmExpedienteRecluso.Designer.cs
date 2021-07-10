namespace Visual.Recluso
{
    partial class FrmExpedienteRecluso
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvRecluso = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnExpediente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecluso)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecluso
            // 
            this.dgvRecluso.AllowUserToAddRows = false;
            this.dgvRecluso.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvRecluso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRecluso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecluso.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecluso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRecluso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecluso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecluso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRecluso.ColumnHeadersHeight = 21;
            this.dgvRecluso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNro,
            this.ColCod,
            this.ColNom,
            this.ColApe,
            this.ColGen,
            this.ColEd,
            this.BtnExpediente});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecluso.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRecluso.EnableHeadersVisualStyles = false;
            this.dgvRecluso.GridColor = System.Drawing.Color.White;
            this.dgvRecluso.Location = new System.Drawing.Point(37, 88);
            this.dgvRecluso.Name = "dgvRecluso";
            this.dgvRecluso.ReadOnly = true;
            this.dgvRecluso.RowHeadersVisible = false;
            this.dgvRecluso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecluso.Size = new System.Drawing.Size(574, 251);
            this.dgvRecluso.TabIndex = 41;
            this.dgvRecluso.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecluso.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRecluso.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRecluso.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRecluso.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRecluso.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecluso.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvRecluso.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvRecluso.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecluso.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvRecluso.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRecluso.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRecluso.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvRecluso.ThemeStyle.ReadOnly = true;
            this.dgvRecluso.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecluso.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecluso.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvRecluso.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRecluso.ThemeStyle.RowsStyle.Height = 22;
            this.dgvRecluso.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRecluso.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColNro
            // 
            this.ColNro.HeaderText = "Nro";
            this.ColNro.Name = "ColNro";
            this.ColNro.ReadOnly = true;
            // 
            // ColCod
            // 
            this.ColCod.HeaderText = "Codigo";
            this.ColCod.Name = "ColCod";
            this.ColCod.ReadOnly = true;
            // 
            // ColNom
            // 
            this.ColNom.HeaderText = "Nombre";
            this.ColNom.Name = "ColNom";
            this.ColNom.ReadOnly = true;
            // 
            // ColApe
            // 
            this.ColApe.HeaderText = "Apellido";
            this.ColApe.Name = "ColApe";
            this.ColApe.ReadOnly = true;
            // 
            // ColGen
            // 
            this.ColGen.HeaderText = "Genero";
            this.ColGen.Name = "ColGen";
            this.ColGen.ReadOnly = true;
            // 
            // ColEd
            // 
            this.ColEd.HeaderText = "Edad";
            this.ColEd.Name = "ColEd";
            this.ColEd.ReadOnly = true;
            // 
            // BtnExpediente
            // 
            this.BtnExpediente.HeaderText = "Expediente";
            this.BtnExpediente.Name = "BtnExpediente";
            this.BtnExpediente.ReadOnly = true;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(213, 37);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(225, 34);
            this.guna2HtmlLabel7.TabIndex = 40;
            this.guna2HtmlLabel7.Text = "Expediente Recluso";
            this.guna2HtmlLabel7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImage = global::Visual.Properties.Resources.ReclusoBG;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.btnMinimizar);
            this.guna2Panel1.Controls.Add(this.btnCerrar);
            this.guna2Panel1.Controls.Add(this.dgvRecluso);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(646, 371);
            this.guna2Panel1.TabIndex = 46;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Image = global::Visual.Properties.Resources.minimize_32;
            this.btnMinimizar.ImageRotate = 0F;
            this.btnMinimizar.Location = new System.Drawing.Point(585, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimizar.ShadowDecoration.Parent = this.btnMinimizar;
            this.btnMinimizar.Size = new System.Drawing.Size(29, 29);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 43;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::Visual.Properties.Resources.close_32;
            this.btnCerrar.ImageRotate = 0F;
            this.btnCerrar.Location = new System.Drawing.Point(615, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCerrar.ShadowDecoration.Parent = this.btnCerrar;
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 42;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmExpedienteRecluso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 371);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmExpedienteRecluso";
            this.Text = "FrmExpedienteRecluso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecluso)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvRecluso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEd;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExpediente;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnMinimizar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnCerrar;
    }
}