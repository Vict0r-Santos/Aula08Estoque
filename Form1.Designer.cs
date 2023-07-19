namespace Aula08Estoque
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.txtQuantidade = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblQuantidade = new System.Windows.Forms.Label();
			this.lblCadastrados = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnProduto1 = new System.Windows.Forms.Button();
			this.btnProdutoUlt = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Indigo;
			this.groupBox1.Controls.Add(this.btnCancelar);
			this.groupBox1.Controls.Add(this.btnSalvar);
			this.groupBox1.Controls.Add(this.txtQuantidade);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtNome);
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(12, 23);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(268, 242);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cadastro";
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.MediumPurple;
			this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCancelar.Location = new System.Drawing.Point(140, 181);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(109, 35);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.Color.MediumPurple;
			this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnSalvar.Location = new System.Drawing.Point(6, 181);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(101, 35);
			this.btnSalvar.TabIndex = 4;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Location = new System.Drawing.Point(6, 145);
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(243, 23);
			this.txtQuantidade.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(6, 115);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(159, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Quantidade em estoque";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(6, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome do produto";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(6, 67);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(243, 23);
			this.txtNome.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Indigo;
			this.groupBox2.Controls.Add(this.lblQuantidade);
			this.groupBox2.Controls.Add(this.lblCadastrados);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.ForeColor = System.Drawing.Color.White;
			this.groupBox2.Location = new System.Drawing.Point(355, 23);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(268, 242);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Informações";
			// 
			// lblQuantidade
			// 
			this.lblQuantidade.AutoSize = true;
			this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblQuantidade.Location = new System.Drawing.Point(123, 181);
			this.lblQuantidade.Name = "lblQuantidade";
			this.lblQuantidade.Size = new System.Drawing.Size(15, 17);
			this.lblQuantidade.TabIndex = 4;
			this.lblQuantidade.Text = "0";
			// 
			// lblCadastrados
			// 
			this.lblCadastrados.AutoSize = true;
			this.lblCadastrados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblCadastrados.Location = new System.Drawing.Point(123, 67);
			this.lblCadastrados.Name = "lblCadastrados";
			this.lblCadastrados.Size = new System.Drawing.Size(15, 17);
			this.lblCadastrados.TabIndex = 3;
			this.lblCadastrados.Text = "0";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(64, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(159, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "Quantidade em estoque";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(53, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(145, 16);
			this.label4.TabIndex = 1;
			this.label4.Text = "Produtos Cadastrados";
			// 
			// btnProduto1
			// 
			this.btnProduto1.BackColor = System.Drawing.Color.MediumSlateBlue;
			this.btnProduto1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnProduto1.Location = new System.Drawing.Point(41, 42);
			this.btnProduto1.Name = "btnProduto1";
			this.btnProduto1.Size = new System.Drawing.Size(160, 35);
			this.btnProduto1.TabIndex = 5;
			this.btnProduto1.Text = "Ver PRIMEIRO Produto";
			this.btnProduto1.UseVisualStyleBackColor = false;
			this.btnProduto1.Click += new System.EventHandler(this.btnProduto1_Click);
			// 
			// btnProdutoUlt
			// 
			this.btnProdutoUlt.BackColor = System.Drawing.Color.MediumPurple;
			this.btnProdutoUlt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnProdutoUlt.Location = new System.Drawing.Point(41, 96);
			this.btnProdutoUlt.Name = "btnProdutoUlt";
			this.btnProdutoUlt.Size = new System.Drawing.Size(160, 35);
			this.btnProdutoUlt.TabIndex = 6;
			this.btnProdutoUlt.Text = "Ver ULTIMO Produto";
			this.btnProdutoUlt.UseVisualStyleBackColor = false;
			this.btnProdutoUlt.Click += new System.EventHandler(this.btnProdutoUlt_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnProduto1);
			this.groupBox3.Controls.Add(this.btnProdutoUlt);
			this.groupBox3.ForeColor = System.Drawing.Color.White;
			this.groupBox3.Location = new System.Drawing.Point(12, 287);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(268, 151);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Operações";
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.BlueViolet;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(408, 311);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(160, 53);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Deletar PRIMEIRO Produto";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(707, 450);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private GroupBox groupBox1;
		private Button btnSalvar;
		private TextBox txtQuantidade;
		private Label label2;
		private Label label1;
		private TextBox txtNome;
		private GroupBox groupBox2;
		private Label lblQuantidade;
		private Label lblCadastrados;
		private Label label3;
		private Label label4;
		private Button btnProduto1;
		private Button btnProdutoUlt;
		private GroupBox groupBox3;
		private Button btnDelete;
		private Button btnCancelar;
	}
}