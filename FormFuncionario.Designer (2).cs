
namespace Projeto
{
    partial class FormFuncionario
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
            this.dgvFunc = new System.Windows.Forms.DataGridView();
            this.lblNomeFunc = new System.Windows.Forms.Label();
            this.lblIdFunc = new System.Windows.Forms.Label();
            this.lblLoginFunc = new System.Windows.Forms.Label();
            this.lblSenhaFunc = new System.Windows.Forms.Label();
            this.txtIdFunc = new System.Windows.Forms.TextBox();
            this.txtLoginFunc = new System.Windows.Forms.TextBox();
            this.txtNomeFunc = new System.Windows.Forms.TextBox();
            this.txtSenhaFunc = new System.Windows.Forms.TextBox();
            this.lblGeneroFunc = new System.Windows.Forms.Label();
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
            this.btnAtualizarFunc = new System.Windows.Forms.Button();
            this.cbxGeneroFunc = new System.Windows.Forms.ComboBox();
            this.btnExcluirFunc = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtCelularFunc = new System.Windows.Forms.TextBox();
            this.lblCelularFunc = new System.Windows.Forms.Label();
            this.btnLocalizarFunc = new System.Windows.Forms.Button();
            this.txtEmailFunc = new System.Windows.Forms.TextBox();
            this.lblEmailFunc = new System.Windows.Forms.Label();
            this.lblDataAdm = new System.Windows.Forms.Label();
            this.txtDataAdm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFunc
            // 
            this.dgvFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunc.Location = new System.Drawing.Point(12, 248);
            this.dgvFunc.Name = "dgvFunc";
            this.dgvFunc.Size = new System.Drawing.Size(653, 170);
            this.dgvFunc.TabIndex = 0;
//            this.dgvFunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFunc_CellContentClick);
            this.dgvFunc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvFunc_MouseDoubleClick);
            // 
            // lblNomeFunc
            // 
            this.lblNomeFunc.AutoSize = true;
            this.lblNomeFunc.Location = new System.Drawing.Point(14, 75);
            this.lblNomeFunc.Name = "lblNomeFunc";
            this.lblNomeFunc.Size = new System.Drawing.Size(43, 13);
            this.lblNomeFunc.TabIndex = 1;
            this.lblNomeFunc.Text = "Nome:";
            // 
            // lblIdFunc
            // 
            this.lblIdFunc.AutoSize = true;
            this.lblIdFunc.Location = new System.Drawing.Point(14, 9);
            this.lblIdFunc.Name = "lblIdFunc";
            this.lblIdFunc.Size = new System.Drawing.Size(92, 13);
            this.lblIdFunc.TabIndex = 2;
            this.lblIdFunc.Text = "Id Funcionário:";
            // 
            // lblLoginFunc
            // 
            this.lblLoginFunc.AutoSize = true;
            this.lblLoginFunc.Location = new System.Drawing.Point(339, 9);
            this.lblLoginFunc.Name = "lblLoginFunc";
            this.lblLoginFunc.Size = new System.Drawing.Size(42, 13);
            this.lblLoginFunc.TabIndex = 4;
            this.lblLoginFunc.Text = "Login:";
            // 
            // lblSenhaFunc
            // 
            this.lblSenhaFunc.AutoSize = true;
            this.lblSenhaFunc.Location = new System.Drawing.Point(339, 75);
            this.lblSenhaFunc.Name = "lblSenhaFunc";
            this.lblSenhaFunc.Size = new System.Drawing.Size(47, 13);
            this.lblSenhaFunc.TabIndex = 6;
            this.lblSenhaFunc.Text = "Senha:";
            // 
            // txtIdFunc
            // 
            this.txtIdFunc.Location = new System.Drawing.Point(17, 25);
            this.txtIdFunc.Name = "txtIdFunc";
            this.txtIdFunc.Size = new System.Drawing.Size(121, 20);
            this.txtIdFunc.TabIndex = 7;
            // 
            // txtLoginFunc
            // 
            this.txtLoginFunc.Location = new System.Drawing.Point(342, 25);
            this.txtLoginFunc.Name = "txtLoginFunc";
            this.txtLoginFunc.Size = new System.Drawing.Size(121, 20);
            this.txtLoginFunc.TabIndex = 9;
            // 
            // txtNomeFunc
            // 
            this.txtNomeFunc.Location = new System.Drawing.Point(17, 91);
            this.txtNomeFunc.Name = "txtNomeFunc";
            this.txtNomeFunc.Size = new System.Drawing.Size(121, 20);
            this.txtNomeFunc.TabIndex = 11;
            // 
            // txtSenhaFunc
            // 
            this.txtSenhaFunc.Location = new System.Drawing.Point(342, 91);
            this.txtSenhaFunc.Name = "txtSenhaFunc";
            this.txtSenhaFunc.Size = new System.Drawing.Size(121, 20);
            this.txtSenhaFunc.TabIndex = 13;
            // 
            // lblGeneroFunc
            // 
            this.lblGeneroFunc.AutoSize = true;
            this.lblGeneroFunc.Location = new System.Drawing.Point(16, 139);
            this.lblGeneroFunc.Name = "lblGeneroFunc";
            this.lblGeneroFunc.Size = new System.Drawing.Size(52, 13);
            this.lblGeneroFunc.TabIndex = 16;
            this.lblGeneroFunc.Text = "Gênero:";
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.Location = new System.Drawing.Point(590, 22);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarFunc.TabIndex = 17;
            this.btnCadastrarFunc.Text = "Cadastrar";
            this.btnCadastrarFunc.UseVisualStyleBackColor = true;
            this.btnCadastrarFunc.Click += new System.EventHandler(this.btnCadastrarFunc_Click);
            // 
            // btnAtualizarFunc
            // 
            this.btnAtualizarFunc.Location = new System.Drawing.Point(590, 51);
            this.btnAtualizarFunc.Name = "btnAtualizarFunc";
            this.btnAtualizarFunc.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarFunc.TabIndex = 18;
            this.btnAtualizarFunc.Text = "Atualizar";
            this.btnAtualizarFunc.UseVisualStyleBackColor = true;
            this.btnAtualizarFunc.Click += new System.EventHandler(this.btnAtualizarFunc_Click);
            // 
            // cbxGeneroFunc
            // 
            this.cbxGeneroFunc.FormattingEnabled = true;
            this.cbxGeneroFunc.Items.AddRange(new object[] {
            "Masculino",
            "Feminino ",
            "Outros"});
            this.cbxGeneroFunc.Location = new System.Drawing.Point(17, 155);
            this.cbxGeneroFunc.Name = "cbxGeneroFunc";
            this.cbxGeneroFunc.Size = new System.Drawing.Size(121, 21);
            this.cbxGeneroFunc.TabIndex = 19;
            // 
            // btnExcluirFunc
            // 
            this.btnExcluirFunc.Location = new System.Drawing.Point(590, 80);
            this.btnExcluirFunc.Name = "btnExcluirFunc";
            this.btnExcluirFunc.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirFunc.TabIndex = 20;
            this.btnExcluirFunc.Text = "Excluir";
            this.btnExcluirFunc.UseVisualStyleBackColor = true;
            this.btnExcluirFunc.Click += new System.EventHandler(this.btnExcluirFunc_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(590, 109);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtCelularFunc
            // 
            this.txtCelularFunc.Location = new System.Drawing.Point(342, 156);
            this.txtCelularFunc.Name = "txtCelularFunc";
            this.txtCelularFunc.Size = new System.Drawing.Size(121, 20);
            this.txtCelularFunc.TabIndex = 22;
            // 
            // lblCelularFunc
            // 
            this.lblCelularFunc.AutoSize = true;
            this.lblCelularFunc.Location = new System.Drawing.Point(339, 140);
            this.lblCelularFunc.Name = "lblCelularFunc";
            this.lblCelularFunc.Size = new System.Drawing.Size(50, 13);
            this.lblCelularFunc.TabIndex = 23;
            this.lblCelularFunc.Text = "Celular:";
            // 
            // btnLocalizarFunc
            // 
            this.btnLocalizarFunc.Location = new System.Drawing.Point(144, 22);
            this.btnLocalizarFunc.Name = "btnLocalizarFunc";
            this.btnLocalizarFunc.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizarFunc.TabIndex = 24;
            this.btnLocalizarFunc.Text = "Localizar:";
            this.btnLocalizarFunc.UseVisualStyleBackColor = true;
            this.btnLocalizarFunc.Click += new System.EventHandler(this.btnLocalizarFunc_Click);
            // 
            // txtEmailFunc
            // 
            this.txtEmailFunc.Location = new System.Drawing.Point(17, 207);
            this.txtEmailFunc.Name = "txtEmailFunc";
            this.txtEmailFunc.Size = new System.Drawing.Size(284, 20);
            this.txtEmailFunc.TabIndex = 25;
            // 
            // lblEmailFunc
            // 
            this.lblEmailFunc.AutoSize = true;
            this.lblEmailFunc.Location = new System.Drawing.Point(16, 191);
            this.lblEmailFunc.Name = "lblEmailFunc";
            this.lblEmailFunc.Size = new System.Drawing.Size(45, 13);
            this.lblEmailFunc.TabIndex = 26;
            this.lblEmailFunc.Text = "E-mail:";
            // 
            // lblDataAdm
            // 
            this.lblDataAdm.AutoSize = true;
            this.lblDataAdm.Location = new System.Drawing.Point(339, 191);
            this.lblDataAdm.Name = "lblDataAdm";
            this.lblDataAdm.Size = new System.Drawing.Size(113, 13);
            this.lblDataAdm.TabIndex = 27;
            this.lblDataAdm.Text = "Data de Admissão:";
            // 
            // txtDataAdm
            // 
            this.txtDataAdm.Location = new System.Drawing.Point(342, 207);
            this.txtDataAdm.Name = "txtDataAdm";
            this.txtDataAdm.Size = new System.Drawing.Size(121, 20);
            this.txtDataAdm.TabIndex = 28;
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 430);
            this.Controls.Add(this.txtDataAdm);
            this.Controls.Add(this.lblDataAdm);
            this.Controls.Add(this.lblEmailFunc);
            this.Controls.Add(this.txtEmailFunc);
            this.Controls.Add(this.btnLocalizarFunc);
            this.Controls.Add(this.lblCelularFunc);
            this.Controls.Add(this.txtCelularFunc);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluirFunc);
            this.Controls.Add(this.cbxGeneroFunc);
            this.Controls.Add(this.btnAtualizarFunc);
            this.Controls.Add(this.btnCadastrarFunc);
            this.Controls.Add(this.lblGeneroFunc);
            this.Controls.Add(this.txtSenhaFunc);
            this.Controls.Add(this.txtNomeFunc);
            this.Controls.Add(this.txtLoginFunc);
            this.Controls.Add(this.txtIdFunc);
            this.Controls.Add(this.lblSenhaFunc);
            this.Controls.Add(this.lblLoginFunc);
            this.Controls.Add(this.lblIdFunc);
            this.Controls.Add(this.lblNomeFunc);
            this.Controls.Add(this.dgvFunc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormFuncionario";
            this.Text = "FormFuncionario";
            this.Load += new System.EventHandler(this.FormFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFunc;
        private System.Windows.Forms.Label lblNomeFunc;
        private System.Windows.Forms.Label lblIdFunc;
        private System.Windows.Forms.Label lblLoginFunc;
        private System.Windows.Forms.Label lblSenhaFunc;
        private System.Windows.Forms.TextBox txtIdFunc;
        private System.Windows.Forms.TextBox txtLoginFunc;
        private System.Windows.Forms.TextBox txtNomeFunc;
        private System.Windows.Forms.TextBox txtSenhaFunc;
        private System.Windows.Forms.Label lblGeneroFunc;
        private System.Windows.Forms.Button btnCadastrarFunc;
        private System.Windows.Forms.Button btnAtualizarFunc;
        private System.Windows.Forms.ComboBox cbxGeneroFunc;
        private System.Windows.Forms.Button btnExcluirFunc;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtCelularFunc;
        private System.Windows.Forms.Label lblCelularFunc;
        private System.Windows.Forms.Button btnLocalizarFunc;
        private System.Windows.Forms.TextBox txtEmailFunc;
        private System.Windows.Forms.Label lblEmailFunc;
        private System.Windows.Forms.Label lblDataAdm;
        private System.Windows.Forms.TextBox txtDataAdm;
    }
}