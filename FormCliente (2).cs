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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }
        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdCli.Text.Trim());
            PetCli petcli = new PetCli();
            petcli.LocalizaCli(id);
            txtNomeCli.Text = petcli.nome;
            txtEnderecoCli.Text = petcli.endereco;
            txtCidadeCli.Text = petcli.cidade;
            txtCelularCli.Text = petcli.celular;
            txtDataCli.Text = petcli.data_nascimento;
            txtEmailCli.Text = petcli.email;
            txtDataCli.Text = petcli.data_nascimento;
        }
        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserirCli_Click(object sender, EventArgs e)
        {
            PetCli pet = new PetCli();
            pet.InserirCli(txtNomeCli.Text, txtEnderecoCli.Text,txtCidadeCli.Text, txtCelularCli.Text,txtEmailCli.Text,txtDataCli.Text);
            MessageBox.Show("Funcionário inserido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<PetCli> cliente = pet.listacli();
            dgvCliente.DataSource = cliente;
            txtNomeCli.Text = "";
            txtDataCli.Text = "";
            txtCelularCli.Text = "";
            txtEnderecoCli.Text = "";
            txtCidadeCli.Text = "";
            txtEmailCli.Text = "";
        }

        private void btnExcluirCli_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdCli.Text.Trim());
            PetCli petcli = new PetCli();
            petcli.ExcluirCli(id);
            MessageBox.Show("Cliente apagado com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<PetCli> cliente = petcli.listacli();
            dgvCliente.DataSource = cliente;
            txtNomeCli.Text = "";
            txtDataCli.Text = "";
            txtCelularCli.Text = "";
            txtEnderecoCli.Text = "";
            txtCidadeCli.Text = "";
            txtEmailCli.Text = "";
        }

        private void btnAtualizaCli_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdCli.Text.Trim());
            PetCli petcli= new PetCli();
            petcli.AtualizaCli(id, txtNomeCli.Text, txtDataCli.Text, txtCelularCli.Text, txtEnderecoCli.Text,txtCidadeCli.Text,txtEmailCli.Text);
            MessageBox.Show("Cliente atualizado com sucesso!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<PetCli> cliente = petcli.listacli();
            dgvCliente.DataSource = cliente;
            txtNomeCli.Text = "";
            txtDataCli.Text = "";
            txtCelularCli.Text = "";
            txtEnderecoCli.Text = "";
            txtCidadeCli.Text = "";
            txtEmailCli.Text = "";
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            PetCli pet = new PetCli();
            List<PetCli> cliente = pet.listacli();
            dgvCliente.DataSource = cliente;
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            var PegarId = dgvCliente.CurrentCell.RowIndex;
            var PegarId2 = dgvCliente.Rows[PegarId].Cells[0].Value.ToString();
            int Id = Convert.ToInt32(PegarId2);
            PetCli pet = new PetCli();
            pet.LocalizaCli(Id);
            txtIdCli.Text = Convert.ToString(Id);
            txtNomeCli.Text = pet.nome;
            txtDataCli.Text = pet.data_nascimento;
            txtCelularCli.Text = pet.celular;
            txtEnderecoCli.Text = pet.endereco;
            txtCidadeCli.Text = pet.cidade;
            txtEmailCli.Text = pet.email;
        }
    }
}
