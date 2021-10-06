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
            // Definições de variáveis para utilização posterior
            int opcao;
            string nomeBanco, nomeCategoria, descricao, nomeBancoConta, categoriaConta;
            float saldoBanco, valor;
        // AQUI É APENAS O MENU INICAL PARA VISUALIZACAO
        MenuInicial:
            Console.Clear();
            Console.WriteLine("==============MENU==================\n1 - Cadastrar Banco e Saldo\n2 - Cadastrar Categoria\n3 - Listar Bancos e Saldo\n4 - Listar Categorias\n5 - Lançar Contas\n6 - Sair\n====================================");
            Console.Write("Sua opção: ");
            // VARIAVEL QUE RECEBE A OPCAO DIGITADA
            opcao = int.Parse(Console.ReadLine());
            switch(opcao)
            {
                case 1:
                    Console.Write("Digite o nome do banco: ");
                    nomeBanco = Console.ReadLine();
                    Console.Write("Digite o saldo incial: ");
                    saldoBanco = float.Parse(Console.ReadLine());
                    // metodo da classe pra criar o banco
                    cadbancario.CriarBanco(nomeBanco, saldoBanco);
                    Console.Write("Pressione ENTER para voltar ao menu");
                    Console.ReadLine();
                    goto MenuInicial;
                case 2:
                    Console.Write("Digite a categoria: ");
                    nomeCategoria = Console.ReadLine();
                    // metodo pra criar categoria
                    cat.CadastroCategoria(nomeCategoria);
                    Console.Write("Pressione ENTER para voltar ao menu");
                    Console.ReadLine();
                    goto MenuInicial;
                case 3:
                    // metodo de exibicao de saldos
                    cadbancario.ExibirSaldos();
                    Console.Write("Pressione ENTER para voltar ao menu");
                    Console.ReadLine();
                    goto MenuInicial;
                case 4:
                    // metodo pra exibir categorias
                    cat.ExibirCategorias();
                    Console.Write("Pressione ENTER para voltar ao menu");
                    Console.ReadLine();
                    goto MenuInicial;
                case 5:
                    Console.Write("Descrição: ");
                    descricao = Console.ReadLine();
                    Console.Write("Valor da conta: ");
                    valor = float.Parse(Console.ReadLine());
                    cadbancario.ListarBancos();
                    Console.Write("Escolha o banco: ");
                    opcao = int.Parse(Console.ReadLine());
                    nomeBancoConta = cadbancario.SelecionarBanco(opcao); // retorna nome do banco de acordo com a posicao
                    cadbancario.AtualizarSaldo(opcao, valor);
                    cat.ExibirCategorias();
                    Console.Write("Escolha a categoria: ");
                    opcao = int.Parse(Console.ReadLine());
                    categoriaConta = cat.SelecionarCategoria(opcao); // retorna nome da categoria de acordo com a posicao
                    contas.LancarConta(descricao, valor, categoriaConta, nomeBancoConta);
                    Console.Write("Pressione ENTER para voltar ao menu");
                    Console.ReadLine();
                    goto MenuInicial;
                case 6:
                    break;
                default:
                    Console.WriteLine("Opcao inválida");
                    goto MenuInicial;
            }

        }
    }
}
