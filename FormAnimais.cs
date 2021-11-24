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
    public partial class FormAnimais : Form
    {
        public FormAnimais()
        {
            InitializeComponent();
        }

        private void btnSairAnimal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocalizarAnimal_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdAnimal.Text.Trim());
            int id_prop = Convert.ToInt32(txtId_Propri_Animal.Text.Trim());
            PetAnimal pet = new PetAnimal();
            pet.LocalizaAnimal(id);
            pet.LocalizaAnimal(id_prop);
            txtNomeAnimal.Text = pet.nome;
            txtRacaAnimal.Text = pet.raca;
            cbxSexoAnimal.Text = pet.sexo;
            txtDataAnimal.Text = pet.data_nascimento;
            txtEspecieAnimal.Text = pet.especie;
            cbxPelagemAnimal.Text = pet.pelagem ;
            txtPesoAnimal.Text = pet.peso;
            cbxPorteAnimal.Text = pet.porte;
            cbxSexoAnimal.Text = pet.sexo;
            cbxPelagemAnimal.Enabled = true;
            cbxPorteAnimal.Enabled = true;
            cbxSexoAnimal.Enabled = true;
        }

        private void btnExcluirAnimal_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdAnimal.Text.Trim());
            int id_prop = Convert.ToInt32(txtId_Propri_Animal.Text.Trim());
            PetAnimal pet = new PetAnimal();
            pet.ExcluirAnimal(id);
            MessageBox.Show("Funcionário excluído com sucesso!", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
            List<PetAnimal> funcionario = pet.listaanimal();
            pet.LocalizaAnimal(id);
            txtNomeAnimal.Text = pet.nome;
            txtRacaAnimal.Text = pet.raca;
            cbxSexoAnimal.Text = pet.sexo;
            txtDataAnimal.Text = pet.data_nascimento;
            txtEspecieAnimal.Text = pet.especie;
            cbxPelagemAnimal.Text = pet.pelagem;
            txtPesoAnimal.Text = pet.peso;
            cbxPorteAnimal.Text = pet.porte;
            cbxSexoAnimal.Text = pet.sexo;
        }
    }
}
