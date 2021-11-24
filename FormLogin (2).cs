using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            string login, senha;
            login = txtLogin.Text;
            senha = txtSenha.Text;
            if(login == "natan" && senha == "123")
            {
                FormPrincipal principal = new FormPrincipal();
                principal.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Os dados inseridos não foram inseridos corretamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtLogin.Text = "";
            txtSenha.Text = "";
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }
    }
}
