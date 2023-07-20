namespace Aula08Estoque
{
	public partial class Form1 : Form
	{
        List<string> produtoNome = new List<string>();
        List<int> produtoQuantidade = new List<int>();

		Utilidades utilidades = new Utilidades();



        public Form1()
		{
			InitializeComponent();
		}

		void adicionaProduto()
		{
			if (utilidades.textBoxEstaVazio(txtNome) == true)
			{
				MessageBox.Show("O campo de nome está vazio");
				return;
			}
			if (utilidades.textBoxEstaVazio(txtQuantidade) == true)
			{
				MessageBox.Show("O campo de quantidade está vazio");
				return;
			}


			string nome = txtNome.Text;
			int quantidade = int.Parse(txtQuantidade.Text);
			produtoNome.Add(nome);
			produtoQuantidade.Add(quantidade);
			MessageBox.Show($"{nome} adicionado com sucesso");



		}

		void atualizaInterface()
		{
			//Quantidade

			int quantidade_cadastrada = produtoNome.Count();
			lblCadastrados.Text = quantidade_cadastrada.ToString();

			//Contabiliza os produtos em estoque

			int estoque = 0;

			for (int i =0; i < produtoQuantidade.Count; i++)
			{
				int quantidade = produtoQuantidade[i];
				estoque += quantidade;
			}
			lblQuantidade.Text = estoque.ToString();
			

		}

		void limpaCampos()
		{
			txtQuantidade.Clear();
			txtNome.Clear();
			txtNome.Focus();
		}

		void verProduto(bool primeiro )
		{
			if (listaEstaVazia() == true)
			{
				MessageBox.Show("Não há produtos para visualizar");
				return;
			}

			string nome;
			int Quantidade;

			if ( primeiro == true ) {

				nome = produtoNome[0];
				Quantidade = produtoQuantidade[0];

			}else{

				nome = produtoNome[produtoNome.Count() - 1];
				Quantidade = produtoQuantidade[produtoQuantidade.Count() - 1];
			}

			MessageBox.Show($"Nome: {nome}, Quantidade: {Quantidade}");
		}

		void remover()
		{
			if(listaEstaVazia() == true)
			{
				MessageBox.Show("Não há produtos para remover");
			}else{
				produtoNome.RemoveAt(0);
				produtoQuantidade.RemoveAt(0);
				atualizaInterface();
			}
			
		}

		bool listaEstaVazia()
		{
			if(produtoNome.Count() > 0)
			{
				return false;
			}else{

				return true;

			}




		}
		private void btnSalvar_Click(object sender, EventArgs e)
		{
			string nome = txtNome.Text;
			adicionaProduto();
			atualizaInterface();
			
			limpaCampos();

		}

		private void button1_Click(object sender, EventArgs e)
		{
			adicionaProduto();
			atualizaInterface();
			limpaCampos();
		}

		private void btnProduto1_Click(object sender, EventArgs e)
		{
			verProduto(true);

			
		}

		private void btnProdutoUlt_Click(object sender, EventArgs e)
		{
			verProduto(false);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			remover();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			Utilidades utilidades = new Utilidades();
			utilidades.mostraMensagem();
		}
	}
}