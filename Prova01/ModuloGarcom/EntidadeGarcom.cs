using Prova01_ControleDeBar.Compartilhado;
using Prova01_ControleDeBar.ModuloCliente;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.ModuloGarcom
{
    internal class EntidadeGarcom : EntidadeBase
    {
        public string nome { get; set; } 
        public string telefone { get; set; }

        public EntidadeGarcom(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            EntidadeGarcom garcom = (EntidadeGarcom)registroAtualizado;
            nome = garcom.nome;
            telefone = garcom.telefone;
        }

        public override ArrayList ValidarErros()
        {
            ArrayList listaErros = new ArrayList();
            if (!telefone.Contains(telefone))
                listaErros.Add("Telefone não cadastrada");
            if (!nome.Contains(nome))
                listaErros.Add("Nome não cadastrada");
            return listaErros;
        }
    }
}
