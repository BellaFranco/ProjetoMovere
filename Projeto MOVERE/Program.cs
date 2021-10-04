using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto_MOVERE
{
    class Program
    {

        static void Main(string[] args)
        {
            CadastroBancario cadbancario;
            cadbancario = new CadastroBancario(); // construtor da classe
            Categoria cat;
            cat = new Categoria(); // construtor da classe
            Contas contas;
            contas = new Contas(); // construtor da classe
            int opcao;
        // AQUI É APENAS O MENU INICAL PARA VISUALIZACAO
        MenuInicial:
            Console.Clear();
            Console.WriteLine("==============MENU==================");
            Console.WriteLine("1 - Cadastrar Banco e Saldo");
            Console.WriteLine("2 - Cadastrar Categoria");
            Console.WriteLine("3 - Listar Bancos e Saldo");
            Console.WriteLine("4 - Listar Categorias");
            Console.WriteLine("5 - Lançar Contas");
            Console.WriteLine("6 - Listar Saldo Bancario");
            Console.WriteLine("7 - Sair");
            Console.WriteLine("====================================");
            Console.Write("Sua opção: ");
            // VARIAVEL QUE RECEBE A OPCAO DIGITADA
            opcao = int.Parse(Console.ReadLine());
            switch(opcao)
            {
                case 1:
                    // uso de variaveis para receber os dados de nome e saldo
                    string nomeBanco;
                    float saldoBanco;
                    Console.Write("Digite o nome do banco: ");
                    nomeBanco = Console.ReadLine();
                    Console.Write("Digite o saldo incial: ");
                    saldoBanco = float.Parse(Console.ReadLine());
                    // funcao da classe pra criar o banco
                    cadbancario.CriarBanco(nomeBanco, saldoBanco);
                    Console.Write("Pressione ENTER para voltar ao menu");
                    Console.ReadLine();
                    goto MenuInicial;
                case 2:
                    string nomeCategoria;
                    Console.Write("Digite a categoria: ");
                    nomeCategoria = Console.ReadLine();
                    cat.CadastroCategoria(nomeCategoria);
                    Console.Write("Pressione ENTER para voltar ao menu");
                    Console.ReadLine();
                    goto MenuInicial;
                case 3:
                    cadbancario.ExibirSaldos();
                    Console.Write("Pressione ENTER para voltar ao menu");
                    Console.ReadLine();
                    goto MenuInicial;
                case 4:
                    cat.ExibirCategorias();
                    Console.Write("Pressione ENTER para voltar ao menu");
                    Console.ReadLine();
                    goto MenuInicial;
                case 5:
                    string descricao;
                    float valor;
                    string nomeBancoConta;
                    string categoriaConta;
                    Console.Write("Descricao: ");
                    descricao = Console.ReadLine();
                    Console.Write("Valor da conta: ");
                    valor = float.Parse(Console.ReadLine());
                    cadbancario.ListarBancos();
                    Console.Write("Escolha o banco: ");
                    opcao = int.Parse(Console.ReadLine());
                    nomeBancoConta = cadbancario.SelecionarBanco(opcao);
                    cadbancario.AtualizarSaldo(opcao, valor);
                    cat.ExibirCategorias();
                    Console.Write("Escolha a categoria: ");
                    opcao = int.Parse(Console.ReadLine());
                    categoriaConta = cat.SelecionarCategoria(opcao);
                    contas.LancarConta(descricao, valor, categoriaConta, nomeBancoConta);
                    Console.Write("Pressione ENTER para voltar ao menu");
                    Console.ReadLine();
                    goto MenuInicial;
                case 6:
                    cadbancario.ExibirSaldos();
                    Console.Write("Pressione ENTER para voltar ao menu");
                    Console.ReadLine();
                    goto MenuInicial;
                case 7:
                    break;
                default:
                    Console.WriteLine("Opcao inválida");
                    goto MenuInicial;
            }

        }
    }
}
