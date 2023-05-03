using Prova01_ControleDeBar.Compartilhado;
using Prova01_ControleDeBar.ModuloGarcom;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.ModuloProduto
{
    internal class EntidadeProduto : EntidadeBase
    {
        public string nome { get; set; }
        public int valor { get; set; }
        public EntidadeProduto(string nome, int valor)
        {
            this.nome = nome;
            this.valor = valor;
        }
        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            EntidadeProduto produtoAtualizado = (EntidadeProduto)registroAtualizado;
            nome = produtoAtualizado.nome;
            valor = produtoAtualizado.valor;
        }

        public override ArrayList ValidarErros()
        {
            ArrayList listaErros = new ArrayList();
            if (!nome.Contains(nome))
                listaErros.Add("Nome não cadastrada");

            return listaErros;
        }
    }
}
