using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova01_ControleDeBar.Compartilhado
{
    public abstract class RepositorioBase
    {
        protected ArrayList registros;
        protected int contadorRegistros = 0;

        public virtual void Inserir(EntidadeBase registro)
        {
            contadorRegistros++;
            registro.id = contadorRegistros;
            registros.Add(registro);
        }

        public virtual void Editar(int id, EntidadeBase registroAtualizado)
        {
            EntidadeBase registroSelecionado = SelecionarPorId(id);
            if (registroAtualizado == null)
            {
                Console.WriteLine("ID não encontrado.");
                return;
            }
            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public virtual void Editar(EntidadeBase registroSelecionado, EntidadeBase registroAtualizado)
        {
            registroSelecionado.AtualizarInformacoes(registroAtualizado);
        }

        public virtual void Excluir(int id)
        {
            EntidadeBase registroSelecionado = SelecionarPorId(id);

            registros.Remove(registroSelecionado);
        }

        public virtual void Excluir(EntidadeBase registroSelecionado)
        {
            registros.Remove(registroSelecionado);
        }

        public virtual EntidadeBase SelecionarPorId(int id)
        {
            EntidadeBase registroSelecionado = null;

            foreach (EntidadeBase registro in registros)
            {
                if (registro.id == id)
                {
                    registroSelecionado = registro;
                    break;
                }
            }

            return registroSelecionado;
        }

        public virtual ArrayList SelecionarTodos()
        {
            return registros;
        }

        public bool TemRegistros()
        {
            return registros.Count > 0;
        }
    }
}
