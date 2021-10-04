using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MOVERE
{
    public class Categoria
    {
        int posicao = 0;
        string[] nomeCategoria = new string[10];
        public void CadastroCategoria(string nomeCategoria)
        {
            this.nomeCategoria[posicao] = nomeCategoria;
            Console.WriteLine("==============================\n CATEGORIA CADASTRADA COM SUCESSO\n==============================");
            posicao++;
        }
        public void ExibirCategorias()
        {
            Console.WriteLine("========== CATEGORIAS ===========");
            int i = 0;
            while (i < 10)
            {
                if (nomeCategoria[i]?.Length > 0)
                {
                    Console.WriteLine("{0} - {1}", i+1, nomeCategoria[i]);
                }
                i++;
            }
            Console.WriteLine("=================================");
        }
        public string SelecionarCategoria(int opcao)
        {
        Inicio:
            if (nomeCategoria[opcao - 1]?.Length > 0)
            {
                Console.WriteLine("Categoria selecionado: {0}", nomeCategoria[opcao - 1]);
                return nomeCategoria[opcao - 1];
            }
            else
            {
                Console.WriteLine("Opcão inexistente");
                goto Selecionar;
            }
        Selecionar:
            Console.WriteLine("Seleciona a categoria: ");
            opcao = int.Parse(Console.ReadLine());
            goto Inicio;
        }
    }


}
