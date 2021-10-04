using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_MOVERE
{
    class Contas
    {
        public int codigoConta = 0;
        public string[] descConta = new string[20];
        public float[] valorConta = new float[20];
        public string[] categoria = new string[20];
        public string[] nomeBanco = new string[20];
        public void LancarConta(string descConta, float valorConta, string categoria, string nomeBanco)
        {
            this.descConta[codigoConta] = descConta;
            this.valorConta[codigoConta] = valorConta;
            this.categoria[codigoConta] = categoria;
            this.nomeBanco[codigoConta] = nomeBanco;
            codigoConta++;
            Console.WriteLine("=================\nCONTA LANCADA COM SUCESSO\n============");
        }
        public void ListarContas()
        {
            Console.WriteLine("========== CONTAS ===========");
            int i = 0;
            while (i < 10)
            {
                if (categoria[i]?.Length > 0)
                {
                    Console.WriteLine("CONTA: {0}\t DESC: {1}\tVALOR: R$ {2}\tCATEGORIA: {3}\tBANCO: {4}", i + 1, descConta[i], valorConta[i], categoria[i], nomeBanco[i]);
                }
                i++;
            }
            Console.WriteLine("=================================");
        }
    }

}
