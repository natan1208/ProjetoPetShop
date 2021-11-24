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
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
        }
        private void FormVenda_Load(object sender, EventArgs e)
        {
            PetServ pet = new PetServ();
            List<PetServ> pets = pet.listaservicos();
            dgvServ.DataSource = pets;
        }
        private void btnLocalizarServ_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdServ.Text.Trim());
            MessageBox.Show("Serviço localizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PetServ serv= new PetServ();
            serv.LocalizaServ(id);
            cbxServico.Text = serv.servico;
            txtPrecoServ.Text = serv.preco;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInserirServ_Click(object sender, EventArgs e)
        {
            PetServ serv = new PetServ();
            string servico = Convert.ToString(cbxServico.SelectedItem);
            serv.InserirServ(servico,txtPrecoServ.Text);
            MessageBox.Show("Serviço inserido com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<PetServ> servi = serv.listaservicos();
            dgvServ.DataSource = servi;
            txtPrecoServ.Text = "";
            cbxServico.SelectedIndex = -1;
        }

        private void btnExcluirServ_Click(object sender, EventArgs e)
        {
            PetServ serv = new PetServ();
            int id = Convert.ToInt32(txtIdServ.Text.Trim());
            serv.ExcluirServ(id);
            MessageBox.Show("Serviço excluido com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<PetServ> li = serv.listaservicos();
            dgvServ.DataSource = li;
            cbxServico.SelectedIndex = -1;
            txtPrecoServ.Text = "";
        }

        private void btnAtualizarServ_Click(object sender, EventArgs e)
        {
            PetServ serv = new PetServ();
            int id = Convert.ToInt32(txtIdServ.Text.Trim());
            serv.AtualizaServ(id, cbxServico.Text, txtPrecoServ.Text);
            MessageBox.Show("Serviço atualizado com sucesso!", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<PetServ> pet = serv.listaservicos();
            dgvServ.DataSource = pet;
            txtPrecoServ.Text = "";
            cbxServico.SelectedIndex = -1;


        }

        private void dgvServ_DoubleClick(object sender, EventArgs e)
        {
            var PegarId = dgvServ.CurrentCell.RowIndex;
            var PegarId2 = dgvServ.Rows[PegarId].Cells[0].Value.ToString();
            int Id = Convert.ToInt32(PegarId2);
            PetServ serv = new PetServ();
            serv.LocalizaServ(Id);
            txtIdServ.Text = Convert.ToString(Id);
            cbxServico.Text = serv.servico;
            txtPrecoServ.Text = serv.preco;
        }


    }
}
