
namespace Projeto
{
    partial class FormVenda
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
            this.btnLocalizarServ = new System.Windows.Forms.Button();
            this.btnInserirServ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxServico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecoServ = new System.Windows.Forms.TextBox();
            this.dgvServ = new System.Windows.Forms.DataGridView();
            this.lblIdServ = new System.Windows.Forms.Label();
            this.txtIdServ = new System.Windows.Forms.TextBox();
            this.btnAtualizarServ = new System.Windows.Forms.Button();
            this.btnExcluirServ = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServ)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLocalizarServ
            // 
            this.btnLocalizarServ.Location = new System.Drawing.Point(148, 22);
            this.btnLocalizarServ.Name = "btnLocalizarServ";
            this.btnLocalizarServ.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizarServ.TabIndex = 0;
            this.btnLocalizarServ.Text = "Localizar";
            this.btnLocalizarServ.UseVisualStyleBackColor = true;
            this.btnLocalizarServ.Click += new System.EventHandler(this.btnLocalizarServ_Click);
            // 
            // btnInserirServ
            // 
            this.btnInserirServ.Location = new System.Drawing.Point(274, 25);
            this.btnInserirServ.Name = "btnInserirServ";
            this.btnInserirServ.Size = new System.Drawing.Size(75, 23);
            this.btnInserirServ.TabIndex = 1;
            this.btnInserirServ.Text = "Inserir";
            this.btnInserirServ.UseVisualStyleBackColor = true;
            this.btnInserirServ.Click += new System.EventHandler(this.btnInserirServ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Serviços:";
            // 
            // cbxServico
            // 
            this.cbxServico.FormattingEnabled = true;
            this.cbxServico.Items.AddRange(new object[] {
            "Banho",
            "Tosa"});
            this.cbxServico.Location = new System.Drawing.Point(12, 81);
            this.cbxServico.Name = "cbxServico";
            this.cbxServico.Size = new System.Drawing.Size(130, 21);
            this.cbxServico.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preço:";
            // 
            // txtPrecoServ
            // 
            this.txtPrecoServ.Location = new System.Drawing.Point(12, 148);
            this.txtPrecoServ.Name = "txtPrecoServ";
            this.txtPrecoServ.Size = new System.Drawing.Size(130, 20);
            this.txtPrecoServ.TabIndex = 6;
            // 
            // dgvServ
            // 
            this.dgvServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServ.Location = new System.Drawing.Point(15, 191);
            this.dgvServ.Name = "dgvServ";
            this.dgvServ.Size = new System.Drawing.Size(334, 247);
            this.dgvServ.TabIndex = 7;
            this.dgvServ.DoubleClick += new System.EventHandler(this.dgvServ_DoubleClick);
            // 
            // lblIdServ
            // 
            this.lblIdServ.AutoSize = true;
            this.lblIdServ.Location = new System.Drawing.Point(12, 9);
            this.lblIdServ.Name = "lblIdServ";
            this.lblIdServ.Size = new System.Drawing.Size(22, 13);
            this.lblIdServ.TabIndex = 8;
            this.lblIdServ.Text = "Id:";
            // 
            // txtIdServ
            // 
            this.txtIdServ.Location = new System.Drawing.Point(12, 25);
            this.txtIdServ.Name = "txtIdServ";
            this.txtIdServ.Size = new System.Drawing.Size(130, 20);
            this.txtIdServ.TabIndex = 9;
            // 
            // btnAtualizarServ
            // 
            this.btnAtualizarServ.Location = new System.Drawing.Point(274, 55);
            this.btnAtualizarServ.Name = "btnAtualizarServ";
            this.btnAtualizarServ.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarServ.TabIndex = 10;
            this.btnAtualizarServ.Text = "Atualizar";
            this.btnAtualizarServ.UseVisualStyleBackColor = true;
            this.btnAtualizarServ.Click += new System.EventHandler(this.btnAtualizarServ_Click);
            // 
            // btnExcluirServ
            // 
            this.btnExcluirServ.Location = new System.Drawing.Point(274, 84);
            this.btnExcluirServ.Name = "btnExcluirServ";
            this.btnExcluirServ.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirServ.TabIndex = 11;
            this.btnExcluirServ.Text = "Excluir";
            this.btnExcluirServ.UseVisualStyleBackColor = true;
            this.btnExcluirServ.Click += new System.EventHandler(this.btnExcluirServ_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(274, 145);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluirServ);
            this.Controls.Add(this.btnAtualizarServ);
            this.Controls.Add(this.txtIdServ);
            this.Controls.Add(this.lblIdServ);
            this.Controls.Add(this.dgvServ);
            this.Controls.Add(this.txtPrecoServ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxServico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInserirServ);
            this.Controls.Add(this.btnLocalizarServ);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVenda";
            this.Text = "FormVenda";
            this.Load += new System.EventHandler(this.FormVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLocalizarServ;
        private System.Windows.Forms.Button btnInserirServ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecoServ;
        private System.Windows.Forms.DataGridView dgvServ;
        private System.Windows.Forms.Label lblIdServ;
        private System.Windows.Forms.TextBox txtIdServ;
        private System.Windows.Forms.Button btnAtualizarServ;
        private System.Windows.Forms.Button btnExcluirServ;
        private System.Windows.Forms.Button btnSair;
    }
}