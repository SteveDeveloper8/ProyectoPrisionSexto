using Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Visual.Cursos;

namespace Visual
{
    public partial class EstudioRegistro : Form
    {
        public EstudioRegistro(string usuario)
        {
            InitializeComponent();
            abrirFormulario<FrmHome>();
            lblBienvenida.Text =usuario;
        }


        private void abrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelPrincipal.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(formulario);
                panelPrincipal.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            abrirFormulario<FrmTalleres>();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            abrirFormulario<FrmDistancia>();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            abrirFormulario<FrmHome>();
        }
    }
}
