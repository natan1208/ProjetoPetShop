using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Data.SqlClient;


namespace Projeto
{
    public partial class FormFuncionario : Form
    {
        public FormPrincipal Total = null;
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            Petshop pet = new Petshop();
            List<Petshop> petshop = pet.listafuncionario();
            dgvFunc.DataSource = petshop;
        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            Petshop pet = new Petshop();
            string genero = Convert.ToString(cbxGeneroFunc.SelectedItem);
            pet.InserirFunc(txtNomeFunc.Text, txtCelularFunc.Text, genero,txtDataAdm.Text,txtLoginFunc.Text,txtSenhaFunc.Text);
            MessageBox.Show("Funcionário inserido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Petshop> funcionario = pet.listafuncionario();
            dgvFunc.DataSource = funcionario;
            txtNomeFunc.Text = "";
            txtCelularFunc.Text = "";
            txtDataAdm.Text = "";
            txtEmailFunc.Text = "";
            txtLoginFunc.Text = "";
            txtSenhaFunc.Text = "";
            cbxGeneroFunc.SelectedIndex = -1;
        }

        private void btnAtualizarFunc_Click(object sender, EventArgs e)
        {
            Petshop pet = new Petshop();
            int id = Convert.ToInt32(txtIdFunc.Text);
            string genero = Convert.ToString(cbxGeneroFunc.SelectedItem);
            pet.AtualizarFunc(id,txtNomeFunc.Text, txtCelularFunc.Text, genero,txtDataAdm.Text, txtLoginFunc.Text, txtSenhaFunc.Text) ;
            MessageBox.Show("Funcionário atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<Petshop> funcionario = pet.listafuncionario();
            dgvFunc.DataSource = funcionario;
            txtNomeFunc.Text = "";
            txtCelularFunc.Text = "";
            txtEmailFunc.Text = "";
            txtLoginFunc.Text = "";
            txtSenhaFunc.Text = "";
            cbxGeneroFunc.SelectedIndex = -1;
        }

        private void btnExcluirFunc_Click(object sender, EventArgs e)
        {
                int id = Convert.ToInt32(txtIdFunc.Text.Trim());
                Petshop pet = new Petshop();
                pet.ExcluirFunc(id);
                MessageBox.Show("Funcionário excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Petshop> funcionario = pet.listafuncionario();
                dgvFunc.DataSource = funcionario;
                txtNomeFunc.Text = "";
                txtCelularFunc.Text = "";
                txtEmailFunc.Text = "";
                txtLoginFunc.Text = "";
                txtSenhaFunc.Text = "";
                cbxGeneroFunc.SelectedIndex = -1;
        }

        private void btnLocalizarFunc_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdFunc.Text.Trim());
            int senha = Convert.ToInt32(txtSenhaFunc.Text.Trim());
            Petshop pet = new Petshop();
            pet.LocalizaFunc(id);
            txtNomeFunc.Text = pet.nome;
            txtCelularFunc.Text = pet.celular;
            cbxGeneroFunc.Text = pet.genero;
            pet.LocalizaFunc(senha);
            cbxGeneroFunc.Enabled = true;
        }

        private void dgvFunc_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var PegarId = dgvFunc.CurrentCell.RowIndex;
            var PegarId2 = dgvFunc.Rows[PegarId].Cells[0].Value.ToString();
            var PegarSenha = dgvFunc.Rows[PegarId].Cells[6].Value.ToString();
            int Id = Convert.ToInt32(PegarId2);
            int senha = Convert.ToInt32(PegarSenha);
            Petshop pet = new Petshop();
            pet.LocalizaFunc(Id);
            txtNomeFunc.Text = pet.nome;
            txtCelularFunc.Text = pet.celular;
            cbxGeneroFunc.Text = pet.genero;
            txtLoginFunc.Text = pet.login;
            pet.LocalizaFunc(senha);
        }
    }
}
