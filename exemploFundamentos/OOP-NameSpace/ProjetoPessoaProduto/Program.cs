using exemploFundamentos.OOP_NameSpace.ProjetoPessoaProduto;

class Program
{
	static void Main(string[] args)
	{
		
		Pessoa pessoa = new Pessoa("Renato", -3);
		pessoa.Apresentar();
		
		Produto produto = new Produto("Computador Acer",-45);
		produto.ExibirDados();
		
		
	}
}
