using Prova01_ControleDeBar.ModuloCliente;
using Prova01_ControleDeBar.ModuloConta;
using Prova01_ControleDeBar.ModuloGarcom;
using Prova01_ControleDeBar.ModuloPedidos;
using Prova01_ControleDeBar.ModuloProduto;
using System.Collections;

namespace Prova01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //registrar o que os clientes consumiram
            //registrar o garçom que atende as mesas
            //mostrar valor faturado
            //O sistema deve permitir a possibilidade de o Sr. João visualizar as contas que estão abertas e o total faturado no dia.




            //Permitir que o garçom registre os pedidos dos clientes em suas respectivas mesas.
            //Permitir a adição e remoção de pedidos/produtos em uma determinada conta.
            //Gerar relatório diário de faturamento do restaurante.
            //Permitir que os funcionários cadastrem produtos
            //Permitir que os funcionários cadastrem mesas
            //Permitir que os funcionários cadastrem garçons.
            RepositorioMesa repositorioMesa = new RepositorioMesa(new ArrayList());
            TelaMesa telaMesa = new TelaMesa(repositorioMesa);

            RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new ArrayList());
            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);

            RepositorioProduto repositorioProduto = new RepositorioProduto(new ArrayList());
            TelaProduto telaProduto = new TelaProduto(repositorioProduto);

            RepositorioPedidos repositorioPedidos = new RepositorioPedidos(new ArrayList());
            TelaPedidos telaPedidos = new TelaPedidos(repositorioPedidos);

            RepositorioConta repositorioConta = new RepositorioConta(new ArrayList());
            TelaConta telaConta = new TelaConta(repositorioConta);

            TesteCadastro(repositorioMesa, repositorioGarcom, repositorioProduto);
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" [1] MENU Garçom [2] MENU Produtos [3] MENU Mesas [4] MENU Contas [5] Para sair");
                Console.Write("Escolha uma opção:  ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        telaGarcom.ApresentarMenu();
                        break;
                    case 2:
                        telaProduto.ApresentarMenu();
                        break;
                    case 3:
                        telaMesa.ApresentarMenu();
                        break;
                    case 4:
                        telaConta.Menu();
                        break;
                }
            } while (opcao != 5);

        }

        private static void TesteCadastro(RepositorioMesa repositorioMesa, RepositorioGarcom repositorioGarcom, RepositorioProduto repositorioProduto)
        {
            EntidadeProduto produto1 = new EntidadeProduto("Cerveja", 15);
            EntidadeProduto produto2 = new EntidadeProduto("Água", 6);
            EntidadeProduto produto3 = new EntidadeProduto("Refri lata", 9);
            EntidadeProduto produto4 = new EntidadeProduto("Porção de Batata", 25);
            EntidadeProduto produto5 = new EntidadeProduto("Porção de Pastél", 35);
            repositorioProduto.Inserir(produto1);
            repositorioProduto.Inserir(produto2);
            repositorioProduto.Inserir(produto3);
            repositorioProduto.Inserir(produto4);
            repositorioProduto.Inserir(produto5);

            EntidadeGarcom garcom1 = new EntidadeGarcom("Jonas, o Consagrado", "234 56 78");
            EntidadeGarcom garcom2 = new EntidadeGarcom("Ernando, o Chefia", "555 102 0800");
            repositorioGarcom.Inserir(garcom1);
            repositorioGarcom.Inserir(garcom2);

            EntidadeMesa mesa1 = new EntidadeMesa(1);
            EntidadeMesa mesa2 = new EntidadeMesa(2);
            EntidadeMesa mesa3 = new EntidadeMesa(3);
            repositorioMesa.Inserir(mesa1);
            repositorioMesa.Inserir(mesa2);
            repositorioMesa.Inserir(mesa3);
        }
    }
}