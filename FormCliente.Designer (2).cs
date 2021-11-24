
namespace Projeto
{
    partial class FormCliente
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
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblNomeCli = new System.Windows.Forms.Label();
            this.lblEndeecoCli = new System.Windows.Forms.Label();
            this.lblCidadeCli = new System.Windows.Forms.Label();
            this.lclCelularCli = new System.Windows.Forms.Label();
            this.lblEmailCli = new System.Windows.Forms.Label();
            this.lblDataCli = new System.Windows.Forms.Label();
            this.txtIdCli = new System.Windows.Forms.TextBox();
            this.txtEnderecoCli = new System.Windows.Forms.TextBox();
            this.txtCelularCli = new System.Windows.Forms.TextBox();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.txtCidadeCli = new System.Windows.Forms.TextBox();
            this.txtEmailCli = new System.Windows.Forms.TextBox();
            this.txtDataCli = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnInserirCli = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluirCli = new System.Windows.Forms.Button();
            this.btnAtualizaCli = new System.Windows.Forms.Button();
            this.btnLocalizarCli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(12, 9);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(61, 13);
            this.lblIdCliente.TabIndex = 0;
            this.lblIdCliente.Text = "IdCliente:";
            // 
            // lblNomeCli
            // 
            this.lblNomeCli.AutoSize = true;
            this.lblNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCli.Location = new System.Drawing.Point(279, 9);
            this.lblNomeCli.Name = "lblNomeCli";
            this.lblNomeCli.Size = new System.Drawing.Size(43, 13);
            this.lblNomeCli.TabIndex = 1;
            this.lblNomeCli.Text = "Nome:";
            // 
            // lblEndeecoCli
            // 
            this.lblEndeecoCli.AutoSize = true;
            this.lblEndeecoCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndeecoCli.Location = new System.Drawing.Point(12, 80);
            this.lblEndeecoCli.Name = "lblEndeecoCli";
            this.lblEndeecoCli.Size = new System.Drawing.Size(65, 13);
            this.lblEndeecoCli.TabIndex = 2;
            this.lblEndeecoCli.Text = "Endereço:";
            // 
            // lblCidadeCli
            // 
            this.lblCidadeCli.AutoSize = true;
            this.lblCidadeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidadeCli.Location = new System.Drawing.Point(279, 80);
            this.lblCidadeCli.Name = "lblCidadeCli";
            this.lblCidadeCli.Size = new System.Drawing.Size(50, 13);
            this.lblCidadeCli.TabIndex = 3;
            this.lblCidadeCli.Text = "Cidade:";
            // 
            // lclCelularCli
            // 
            this.lclCelularCli.AutoSize = true;
            this.lclCelularCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lclCelularCli.Location = new System.Drawing.Point(12, 145);
            this.lclCelularCli.Name = "lclCelularCli";
            this.lclCelularCli.Size = new System.Drawing.Size(50, 13);
            this.lclCelularCli.TabIndex = 4;
            this.lclCelularCli.Text = "Celular:";
            // 
            // lblEmailCli
            // 
            this.lblEmailCli.AutoSize = true;
            this.lblEmailCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailCli.Location = new System.Drawing.Point(281, 145);
            this.lblEmailCli.Name = "lblEmailCli";
            this.lblEmailCli.Size = new System.Drawing.Size(41, 13);
            this.lblEmailCli.TabIndex = 5;
            this.lblEmailCli.Text = "Email:";
            // 
            // lblDataCli
            // 
            this.lblDataCli.AutoSize = true;
            this.lblDataCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCli.Location = new System.Drawing.Point(472, 9);
            this.lblDataCli.Name = "lblDataCli";
            this.lblDataCli.Size = new System.Drawing.Size(126, 13);
            this.lblDataCli.TabIndex = 6;
            this.lblDataCli.Text = "Data de Nascimento:";
            // 
            // txtIdCli
            // 
            this.txtIdCli.Location = new System.Drawing.Point(12, 25);
            this.txtIdCli.Name = "txtIdCli";
            this.txtIdCli.Size = new System.Drawing.Size(141, 20);
            this.txtIdCli.TabIndex = 7;
            // 
            // txtEnderecoCli
            // 
            this.txtEnderecoCli.Location = new System.Drawing.Point(12, 96);
            this.txtEnderecoCli.Name = "txtEnderecoCli";
            this.txtEnderecoCli.Size = new System.Drawing.Size(141, 20);
            this.txtEnderecoCli.TabIndex = 8;
            // 
            // txtCelularCli
            // 
            this.txtCelularCli.Location = new System.Drawing.Point(12, 161);
            this.txtCelularCli.Name = "txtCelularCli";
            this.txtCelularCli.Size = new System.Drawing.Size(141, 20);
            this.txtCelularCli.TabIndex = 9;
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.Location = new System.Drawing.Point(282, 25);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(141, 20);
            this.txtNomeCli.TabIndex = 10;
            // 
            // txtCidadeCli
            // 
            this.txtCidadeCli.Location = new System.Drawing.Point(282, 96);
            this.txtCidadeCli.Name = "txtCidadeCli";
            this.txtCidadeCli.Size = new System.Drawing.Size(141, 20);
            this.txtCidadeCli.TabIndex = 11;
            // 
            // txtEmailCli
            // 
            this.txtEmailCli.Location = new System.Drawing.Point(282, 161);
            this.txtEmailCli.Name = "txtEmailCli";
            this.txtEmailCli.Size = new System.Drawing.Size(141, 20);
            this.txtEmailCli.TabIndex = 12;
            // 
            // txtDataCli
            // 
            this.txtDataCli.Location = new System.Drawing.Point(475, 25);
            this.txtDataCli.Name = "txtDataCli";
            this.txtDataCli.Size = new System.Drawing.Size(141, 20);
            this.txtDataCli.TabIndex = 13;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(12, 200);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(744, 238);
            this.dgvCliente.TabIndex = 14;
            this.dgvCliente.DoubleClick += new System.EventHandler(this.dgvCliente_DoubleClick);
            // 
            // btnInserirCli
            // 
            this.btnInserirCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirCli.Location = new System.Drawing.Point(651, 25);
            this.btnInserirCli.Name = "btnInserirCli";
            this.btnInserirCli.Size = new System.Drawing.Size(81, 23);
            this.btnInserirCli.TabIndex = 15;
            this.btnInserirCli.Text = "Inserir";
            this.btnInserirCli.UseVisualStyleBackColor = true;
            this.btnInserirCli.Click += new System.EventHandler(this.btnInserirCli_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(651, 112);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 23);
            this.btnSair.TabIndex = 16;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnExcluirCli
            // 
            this.btnExcluirCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCli.Location = new System.Drawing.Point(651, 83);
            this.btnExcluirCli.Name = "btnExcluirCli";
            this.btnExcluirCli.Size = new System.Drawing.Size(81, 23);
            this.btnExcluirCli.TabIndex = 17;
            this.btnExcluirCli.Text = "Excluir";
            this.btnExcluirCli.UseVisualStyleBackColor = true;
            this.btnExcluirCli.Click += new System.EventHandler(this.btnExcluirCli_Click);
            // 
            // btnAtualizaCli
            // 
            this.btnAtualizaCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizaCli.Location = new System.Drawing.Point(651, 54);
            this.btnAtualizaCli.Name = "btnAtualizaCli";
            this.btnAtualizaCli.Size = new System.Drawing.Size(81, 23);
            this.btnAtualizaCli.TabIndex = 18;
            this.btnAtualizaCli.Text = "Atualizar";
            this.btnAtualizaCli.UseVisualStyleBackColor = true;
            this.btnAtualizaCli.Click += new System.EventHandler(this.btnAtualizaCli_Click);
            // 
            // btnLocalizarCli
            // 
            this.btnLocalizarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalizarCli.Location = new System.Drawing.Point(159, 22);
            this.btnLocalizarCli.Name = "btnLocalizarCli";
            this.btnLocalizarCli.Size = new System.Drawing.Size(81, 23);
            this.btnLocalizarCli.TabIndex = 19;
            this.btnLocalizarCli.Text = "Localizar";
            this.btnLocalizarCli.UseVisualStyleBackColor = true;
            this.btnLocalizarCli.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(472, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 20;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLocalizarCli);
            this.Controls.Add(this.btnAtualizaCli);
            this.Controls.Add(this.btnExcluirCli);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInserirCli);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.txtDataCli);
            this.Controls.Add(this.txtEmailCli);
            this.Controls.Add(this.txtCidadeCli);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.txtCelularCli);
            this.Controls.Add(this.txtEnderecoCli);
            this.Controls.Add(this.txtIdCli);
            this.Controls.Add(this.lblDataCli);
            this.Controls.Add(this.lblEmailCli);
            this.Controls.Add(this.lclCelularCli);
            this.Controls.Add(this.lblCidadeCli);
            this.Controls.Add(this.lblEndeecoCli);
            this.Controls.Add(this.lblNomeCli);
            this.Controls.Add(this.lblIdCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblNomeCli;
        private System.Windows.Forms.Label lblEndeecoCli;
        private System.Windows.Forms.Label lblCidadeCli;
        private System.Windows.Forms.Label lclCelularCli;
        private System.Windows.Forms.Label lblEmailCli;
        private System.Windows.Forms.Label lblDataCli;
        private System.Windows.Forms.TextBox txtIdCli;
        private System.Windows.Forms.TextBox txtEnderecoCli;
        private System.Windows.Forms.TextBox txtCelularCli;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.TextBox txtCidadeCli;
        private System.Windows.Forms.TextBox txtEmailCli;
        private System.Windows.Forms.TextBox txtDataCli;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnInserirCli;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluirCli;
        private System.Windows.Forms.Button btnAtualizaCli;
        private System.Windows.Forms.Button btnLocalizarCli;
        private System.Windows.Forms.Label label1;
    }
}