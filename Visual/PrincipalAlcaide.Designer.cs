namespace Visual
{
    partial class PrincipalAlcaide
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.reclusoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CerrarSesion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMinimizar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnCerrar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.registrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BtnExpediente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColEd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvReclusos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReclusos)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.reclusoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Gray;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRegistrar,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItem1.Text = "Estudio";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MenuRegistrar
            // 
            this.MenuRegistrar.BackColor = System.Drawing.Color.DarkKhaki;
            this.MenuRegistrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem1,
            this.consultarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.MenuRegistrar.Name = "MenuRegistrar";
            this.MenuRegistrar.Size = new System.Drawing.Size(235, 24);
            this.MenuRegistrar.Text = "Educación a distancia";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.DarkKhaki;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(235, 24);
            this.toolStripMenuItem3.Text = "Formación Profesional";
            // 
            // reclusoToolStripMenuItem
            // 
            this.reclusoToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.reclusoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.actualizarToolStripMenuItem});
            this.reclusoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reclusoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reclusoToolStripMenuItem.Name = "reclusoToolStripMenuItem";
            this.reclusoToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.reclusoToolStripMenuItem.Text = "Actividades";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.BackColor = System.Drawing.Color.DarkKhaki;
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.registrarToolStripMenuItem.Text = "Trabajos";
            // 
            // actualizarToolStripMenuItem
            // 
            this.actualizarToolStripMenuItem.BackColor = System.Drawing.Color.DarkKhaki;
            this.actualizarToolStripMenuItem.Name = "actualizarToolStripMenuItem";
            this.actualizarToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.actualizarToolStripMenuItem.Text = "Talleres";
            // 
            // CerrarSesion
            // 
            this.CerrarSesion.BackColor = System.Drawing.Color.Transparent;
            this.CerrarSesion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarSesion.ForeColor = System.Drawing.Color.White;
            this.CerrarSesion.Location = new System.Drawing.Point(423, 289);
            this.CerrarSesion.Name = "CerrarSesion";
            this.CerrarSesion.Size = new System.Drawing.Size(103, 23);
            this.CerrarSesion.TabIndex = 24;
            this.CerrarSesion.Text = "Cerrar Sesión";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::Visual.Properties.Resources.icons8_sign_out_32;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(532, 289);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(25, 23);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 25;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Tag = "Cerrar Sesion";
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Gray;
            this.btnMinimizar.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Image = global::Visual.Properties.Resources.minimize_32;
            this.btnMinimizar.ImageRotate = 0F;
            this.btnMinimizar.Location = new System.Drawing.Point(501, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnMinimizar.ShadowDecoration.Parent = this.btnMinimizar;
            this.btnMinimizar.Size = new System.Drawing.Size(29, 27);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 23;
            this.btnMinimizar.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Gray;
            this.btnCerrar.FillColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = global::Visual.Properties.Resources.close_32;
            this.btnCerrar.ImageRotate = 0F;
            this.btnCerrar.Location = new System.Drawing.Point(536, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCerrar.ShadowDecoration.Parent = this.btnCerrar;
            this.btnCerrar.Size = new System.Drawing.Size(24, 24);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.TabStop = false;
            // 
            // registrarToolStripMenuItem1
            // 
            this.registrarToolStripMenuItem1.Name = "registrarToolStripMenuItem1";
            this.registrarToolStripMenuItem1.Size = new System.Drawing.Size(180, 24);
            this.registrarToolStripMenuItem1.Text = "Registrar";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(211, -71);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(245, 34);
            this.guna2HtmlLabel7.TabIndex = 47;
            this.guna2HtmlLabel7.Text = "Consulta de Reclusos";
            this.guna2HtmlLabel7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // BtnExpediente
            // 
            this.BtnExpediente.HeaderText = "Expediente";
            this.BtnExpediente.Name = "BtnExpediente";
            this.BtnExpediente.ReadOnly = true;
            // 
            // ColEd
            // 
            this.ColEd.HeaderText = "FechaNac";
            this.ColEd.Name = "ColEd";
            this.ColEd.ReadOnly = true;
            // 
            // ColGen
            // 
            this.ColGen.HeaderText = "Genero";
            this.ColGen.Name = "ColGen";
            this.ColGen.ReadOnly = true;
            // 
            // col_Cedula
            // 
            this.col_Cedula.HeaderText = "Cédula";
            this.col_Cedula.Name = "col_Cedula";
            this.col_Cedula.ReadOnly = true;
            // 
            // ColApe
            // 
            this.ColApe.HeaderText = "Apellidos";
            this.ColApe.Name = "ColApe";
            this.ColApe.ReadOnly = true;
            // 
            // ColNom
            // 
            this.ColNom.HeaderText = "Nombres";
            this.ColNom.Name = "ColNom";
            this.ColNom.ReadOnly = true;
            // 
            // ColCod
            // 
            this.ColCod.HeaderText = "Codigo";
            this.ColCod.Name = "ColCod";
            this.ColCod.ReadOnly = true;
            // 
            // dgvReclusos
            // 
            this.dgvReclusos.AllowUserToAddRows = false;
            this.dgvReclusos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvReclusos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReclusos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReclusos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvReclusos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvReclusos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReclusos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReclusos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReclusos.ColumnHeadersHeight = 21;
            this.dgvReclusos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCod,
            this.ColNom,
            this.ColApe,
            this.col_Cedula,
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
            this.dgvReclusos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReclusos.EnableHeadersVisualStyles = false;
            this.dgvReclusos.GridColor = System.Drawing.Color.White;
            this.dgvReclusos.Location = new System.Drawing.Point(12, 82);
            this.dgvReclusos.Name = "dgvReclusos";
            this.dgvReclusos.ReadOnly = true;
            this.dgvReclusos.RowHeadersVisible = false;
            this.dgvReclusos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReclusos.Size = new System.Drawing.Size(545, 189);
            this.dgvReclusos.TabIndex = 48;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Reclusos con condena menor a 100 días.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PrincipalAlcaide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visual.Properties.Resources.ReclusoBG;
            this.ClientSize = new System.Drawing.Size(569, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvReclusos);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.CerrarSesion);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalAlcaide";
            this.Text = "PrincipalAlcaide";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReclusos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel CerrarSesion;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnMinimizar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnCerrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuRegistrar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem reclusoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvReclusos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApe;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEd;
        private System.Windows.Forms.DataGridViewButtonColumn BtnExpediente;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
    }
}