using ControleDeBar.ConsoleApp.Compartilhado;
using Prova01_ControleDeBar.Compartilhado;
using Prova01_ControleDeBar.ModuloCliente;
using Prova01_ControleDeBar.ModuloGarcom;
using Prova01_ControleDeBar.ModuloPedidos;
using Prova01_ControleDeBar.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.ModuloConta
{
    internal class TelaConta : TelaBase
    {
        private RepositorioConta repositorioConta;
        private RepositorioGarcom repositorioGarcom;
        private RepositorioMesa repositorioMesa;
        private RepositorioProduto repositorioProduto;


        public TelaConta(RepositorioConta repositorioConta, RepositorioGarcom repositorioGarcom, RepositorioMesa repositorioMesa, RepositorioProduto repositorioProduto, TelaGarcom telaGarcom, TelaProduto telaProduto, TelaMesa telaMesa)
        {
            this.repositorioConta = repositorioConta;
            this.repositorioGarcom = repositorioGarcom;
            this.repositorioMesa = repositorioMesa;
            this.repositorioProduto = repositorioProduto;
            nomeEntidade = "Conta";
            sufixo = "s";
        }

        public TelaConta(RepositorioConta repositorioConta)
        {
            this.repositorioConta = repositorioConta;
        }

        public void Menu()
        {
            int opcao = 0;
            do
            {
                Console.WriteLine($"Cadastro de {nomeEntidade}{sufixo} \n");

                Console.WriteLine($"Digite 1 para Inserir {nomeEntidade}");
                Console.WriteLine($"Digite 2 para Anotar Pedido");
                Console.WriteLine($"Digite 3 para Fechar {nomeEntidade}{sufixo}");
                Console.WriteLine($"Digite 4 para Visualizar {nomeEntidade}{sufixo}\n");
                Console.WriteLine($"Digite 5 para Visualizar faturamento");
                Console.WriteLine("Digite 6 para Sair");

                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1: InserirNovoRegistro(); break;
                    case 2: AnotarPedidos(); break;
                    case 3: FecharConta(); break;
                    case 4: VisualizarRegistros(false); break;
                    case 5: Faturamento(); break;

                }
            } while (opcao != 6);

        }

        private void FecharConta()
        {
            Console.Clear();
            ArrayList contas = repositorioConta.SelecionarTodos();

            Console.WriteLine(" {0, -10} | {1, -20} | {2, -10} ", "ID", "MESA", "CONTA EM ABERTO");
            foreach (EntidadeConta c in contas)
            {
                Console.WriteLine(" {0, -10} | {1, -20} | {2, -10} ", c.id, c.mesa, c.contaAberta);
            }

            EntidadeConta contaFechada = (EntidadeConta)EncontrarRegistro("Digite o ID da conta");
            contaFechada.EncerrarConta(true);
        }

        private void Faturamento()
        {
            int valorTotal = 0;

            ArrayList contaRegistro = repositorioConta.SelecionarTodos();

            foreach (EntidadeConta info in contaRegistro)
            {
                foreach (EntidadePedidos p in info.pedidos)
                {
                    valorTotal += p.quantidade * p.produto.valor;
                }
            }
            MostrarMensagem($"Total faturado: R${valorTotal}", ConsoleColor.Green);
        }

        private void AnotarPedidos()
        {
            ArrayList contas = repositorioConta.SelecionarTodos();
            Console.WriteLine("{0,-10} |{1,-10} |{2,-10} ", "ID", "MESA", "GARÇOM");
            foreach (EntidadeConta c in contas)
            {
                Console.WriteLine("{0,-10} |{1,-10} |{2,-10}", c.id, c.mesa, c.garcom.id);
            }
            EntidadeConta conta = (EntidadeConta)EncontrarRegistro("Digite o id da conta");
            bool pedidos = true;
            do
            {
                ArrayList produtos = repositorioProduto.SelecionarTodos();
                Console.WriteLine("{0,-10} | {1,-10} | {2,-10}", "ID", "NOME", "PREÇO");
                foreach (EntidadeProduto p in produtos)
                {
                    Console.WriteLine("{0,-10} | {1,-10} | {2,-10}", p.id, p.nome, p.valor);
                }
                EntidadeProduto produto = (EntidadeProduto)EncontrarRegistro("Digite o id do produto");
                Console.WriteLine("Digite a quantidade do produto");
                int quantidade = Convert.ToInt32(Console.ReadLine());
                EntidadePedidos pedido = new EntidadePedidos(produto, conta.id, conta.garcom, quantidade);
                conta.AnotarPedido(pedido);
                Console.WriteLine("Deseja continuar? 1 para sim, 2 para não.");
                int continuar = Convert.ToInt32(Console.ReadLine());
                if (continuar == 1)
                    pedidos = true;
                if (continuar == 2)
                    pedidos = false;
            } while (pedidos);

        }

        protected override void MostrarTabela(ArrayList contas)
        {
            repositorioConta.SelecionarTodos();
            Console.WriteLine("{0,-10} |{1,-10} |{2,-10} |{3,-10} |{4,-10}", "ID", "MESA", "GARÇOM", "PEDIDO");
            foreach (EntidadeConta c in contas)
            {
                Console.WriteLine("{0,-10} |{1,-10} |{2,-10} |{3,-10} |{4,-10}", c.id, c.mesa, c.garcom.id, c.pedidos);
            }
            Console.ReadLine();
        }

        protected override EntidadeBase ObterRegistro()
        {
            ArrayList mesas = repositorioMesa.SelecionarTodos();

            Console.WriteLine("\n {0, -10} | {1, -10} ", "ID", "MESA");

            EntidadeMesa mesaEscolhida = (EntidadeMesa)EncontrarRegistro("Digite o ID da mesa");

            ArrayList garcom = repositorioGarcom.SelecionarTodos();


            Console.WriteLine("\n {0, -10} | {1, -10} | {2, -10} ", "ID", "NOME", "TELEFONE");
            foreach (EntidadeGarcom g in garcom)
            {
                Console.WriteLine(" {0, -10} | {1, -10} | {2, -10}", g.id, g.nome, g.telefone);
            }      

            EntidadeGarcom funcionarioEscolhido = (EntidadeGarcom)EncontrarRegistro("Digite o ID do funcionário");

            EntidadeConta novaConta = new EntidadeConta(repositorioMesa, funcionarioEscolhido, garcom, true);
            return novaConta;
        }
    }
}