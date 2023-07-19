namespace Aula08Estoque
{
	public partial class Form1 : Form
	{
        List<string> produtoNome = new List<string>();
        List<int> produtoQuantidade = new List<int>();



        public Form1()
		{
			InitializeComponent();
		}

		void adicionaProduto()
		{
			string nome = txtNome.Text;
			int quantidade = int.Parse(txtQuantidade.Text);
			produtoNome.Add(nome);
			produtoQuantidade.Add(quantidade);
		}

		void atualizaInterface()
		{
			int quantidade_cadastrada = produtoNome.Count();
			lblCadastrados.Text = quantidade_cadastrada.ToString();
			

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
			MessageBox.Show($"{nome} adicionado com sucesso");
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
	}
}