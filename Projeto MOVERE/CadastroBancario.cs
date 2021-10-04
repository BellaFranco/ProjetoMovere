using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MOVERE
{
    public class CadastroBancario
    {
        int posicao = 0;
        public string[] nomeBanco = new string[5];
        public float[] saldoBanco = new float[5];
        float valorTotal;

        public void CriarBanco(string nomeBanco, float saldoBanco)
        {
            this.nomeBanco[posicao] = nomeBanco;
            this.saldoBanco[posicao] = saldoBanco;
            Console.WriteLine("==============================\n SALDO LANÇADO COM SUCESSO\n==============================");
            posicao++;
        }
        public void ExibirSaldos()
        {
            int i = 0;
            while (i < 5)
            {
                if(saldoBanco[i] > 0)
                {
                    Console.WriteLine("Banco {1}    Saldo R$ {0}", saldoBanco[i], nomeBanco[i]);
                }
                valorTotal = valorTotal + saldoBanco[i];
                i++;
            }
            Console.WriteLine("Saldo Total: R$ {0}", valorTotal);
            valorTotal = 0;
        }
        public void ListarBancos()
        {
            Console.WriteLine("============ BANCOS ============");
            int i = 0;
            while (i < 5)
            {
                if (saldoBanco[i] > 0)
                {
                    Console.WriteLine("{0} - {1}", i+1 , nomeBanco[i]);
                }
                i++;
            }
            Console.WriteLine("================================");
        }
        public string SelecionarBanco(int opcao)
        {
        Inicio:
            if (nomeBanco[opcao-1]?.Length > 0)
            {
                Console.WriteLine("Banco selecionado: {0}", nomeBanco[opcao-1]);
                return nomeBanco[opcao-1];
            }
            else
            {
                Console.WriteLine("Opcão inexistente");
                goto Selecionar;
            }
        Selecionar:
            Console.WriteLine("Seleciona o seu banco: ");
            opcao = int.Parse(Console.ReadLine());
            goto Inicio;
        }
        public void AtualizarSaldo(int opcao, float valor)
        {
                this.saldoBanco[opcao - 1] = saldoBanco[opcao - 1] - valor;
        }
    }
}
