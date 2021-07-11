namespace Visual.Recluso
{
    partial class FrmConsultarRecluso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvReclusos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnExpediente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnInicioSesion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReclusos)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Image = global::Visual.Properties.Resources.minimize_32;
            this.btnMinimizar.ImageRotate = 0F;
            this.btnMinimizar.Location = new System.Drawing.Point(563, 10);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimizar.ShadowDecoration.Parent = this.btnMinimizar;
            this.btnMinimizar.Size = new System.Drawing.Size(29, 29);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 34;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::Visual.Properties.Resources.close_32;
            this.btnCerrar.ImageRotate = 0F;
            this.btnCerrar.Location = new System.Drawing.Point(595, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCerrar.ShadowDecoration.Parent = this.btnCerrar;
            this.btnCerrar.Size = new System.Drawing.Size(25, 25);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 33;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(195, 35);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(245, 34);
            this.guna2HtmlLabel7.TabIndex = 35;
            this.guna2HtmlLabel7.Text = "Consulta de Reclusos";
            this.guna2HtmlLabel7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(64, 90);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(74, 32);
            this.guna2HtmlLabel3.TabIndex = 37;
            this.guna2HtmlLabel3.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Transparent;
            this.txtCodigo.BorderRadius = 15;
            this.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigo.DefaultText = "";
            this.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.DisabledState.Parent = this.txtCodigo;
            this.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigo.FillColor = System.Drawing.Color.Transparent;
            this.txtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.FocusedState.Parent = this.txtCodigo;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigo.ForeColor = System.Drawing.Color.Transparent;
            this.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigo.HoverState.Parent = this.txtCodigo;
            this.txtCodigo.Location = new System.Drawing.Point(144, 90);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.PlaceholderText = "";
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.ShadowDecoration.Parent = this.txtCodigo;
            this.txtCodigo.Size = new System.Drawing.Size(261, 36);
            this.txtCodigo.TabIndex = 38;
            // 
            // dgvReclusos
            // 
            this.dgvReclusos.AllowUserToAddRows = false;
            this.dgvReclusos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvReclusos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReclusos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReclusos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReclusos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReclusos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReclusos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReclusos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReclusos.ColumnHeadersHeight = 21;
            this.dgvReclusos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCod,
            this.ColNom,
            this.ColApe,
            this.col_Cedula,
            this.ColGen,
            this.ColEd,
            this.BtnExpediente});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReclusos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReclusos.EnableHeadersVisualStyles = false;
            this.dgvReclusos.GridColor = System.Drawing.Color.White;
            this.dgvReclusos.Location = new System.Drawing.Point(29, 157);
            this.dgvReclusos.Name = "dgvReclusos";
            this.dgvReclusos.ReadOnly = true;
            this.dgvReclusos.RowHeadersVisible = false;
            this.dgvReclusos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReclusos.Size = new System.Drawing.Size(574, 251);
            this.dgvReclusos.TabIndex = 39;
            this.dgvReclusos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReclusos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReclusos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReclusos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReclusos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReclusos.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReclusos.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvReclusos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvReclusos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReclusos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvReclusos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReclusos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvReclusos.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvReclusos.ThemeStyle.ReadOnly = true;
            this.dgvReclusos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReclusos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReclusos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvReclusos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReclusos.ThemeStyle.RowsStyle.Height = 22;
            this.dgvReclusos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReclusos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReclusos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReclusos_CellContentClick);
            // 
            // ColCod
            // 
            this.ColCod.HeaderText = "Codigo";
            this.ColCod.Name = "ColCod";
            this.ColCod.ReadOnly = true;
            // 
            // ColNom
            // 
            this.ColNom.HeaderText = "Nombres";
            this.ColNom.Name = "ColNom";
            this.ColNom.ReadOnly = true;
            // 
            // ColApe
            // 
            this.ColApe.HeaderText = "Apellidos";
            this.ColApe.Name = "ColApe";
            this.ColApe.ReadOnly = true;
            // 
            // col_Cedula
            // 
            this.col_Cedula.HeaderText = "Cédula";
            this.col_Cedula.Name = "col_Cedula";
            this.col_Cedula.ReadOnly = true;
            // 
            // ColGen
            // 
            this.ColGen.HeaderText = "Genero";
            this.ColGen.Name = "ColGen";
            this.ColGen.ReadOnly = true;
            // 
            // ColEd
            // 
            this.ColEd.HeaderText = "FechaNac";
            this.ColEd.Name = "ColEd";
            this.ColEd.ReadOnly = true;
            // 
            // BtnExpediente
            // 
            this.BtnExpediente.HeaderText = "Expediente";
            this.BtnExpediente.Name = "BtnExpediente";
            this.BtnExpediente.ReadOnly = true;
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.BackColor = System.Drawing.Color.Transparent;
            this.btnInicioSesion.BorderRadius = 20;
            this.btnInicioSesion.CheckedState.Parent = this.btnInicioSesion;
            this.btnInicioSesion.CustomImages.Parent = this.btnInicioSesion;
            this.btnInicioSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInicioSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInicioSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInicioSesion.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInicioSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInicioSesion.DisabledState.Parent = this.btnInicioSesion;
            this.btnInicioSesion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInicioSesion.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInicioSesion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnInicioSesion.ForeColor = System.Drawing.Color.White;
            this.btnInicioSesion.HoverState.Parent = this.btnInicioSesion;
            this.btnInicioSesion.Location = new System.Drawing.Point(424, 90);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.ShadowDecoration.Parent = this.btnInicioSesion;
            this.btnInicioSesion.Size = new System.Drawing.Size(125, 38);
            this.btnInicioSesion.TabIndex = 40;
            this.btnInicioSesion.Text = "Buscar";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BackgroundImage = global::Visual.Properties.Resources.ReclusoBG;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(632, 434);
            this.guna2Panel1.TabIndex = 45;
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseMove);
            // 
            // FrmConsultarRecluso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visual.Properties.Resources.ReclusoBG;
            this.ClientSize = new System.Drawing.Size(632, 434);
            this.Controls.Add(this.btnInicioSesion);
            this.Controls.Add(this.dgvReclusos);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarRecluso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarRecluso";
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReclusos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnMinimizar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnCerrar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReclusos;
        private Guna.UI2.WinForms.Guna2GradientButton btnInicioSesion;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEd;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExpediente;
    }
}