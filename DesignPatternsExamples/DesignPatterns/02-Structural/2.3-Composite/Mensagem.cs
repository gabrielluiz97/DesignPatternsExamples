using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._3_Composite
{
    public class Mensagem : IMensagem, IEnumerable<IMensagem>
    {
        private readonly List<IMensagem> _lista = new List<IMensagem>();

        public Mensagem(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; set; }

        public void AdicionarFilha(IMensagem filha)
        {
            _lista.Add(filha);
        }       
        
        public void RemoverFilha(IMensagem filha)
        {
            _lista.Remove(filha);
        }      
        
        public IMensagem ObterFilha(int index)
        {
           return _lista[index];
        }       
        
        public IMensagem ObterFilha(string descricao)
        {
           return _lista.FirstOrDefault(m => m.Descricao == descricao);
        }

        public IEnumerable<IMensagem> ObterLista()
            => _lista;

        public IEnumerator<IMensagem> GetEnumerator()
        {
            return ((IEnumerable<IMensagem>)_lista).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<IMensagem>)_lista).GetEnumerator();
        }

        public void ExibirMensagens(int sub)
        {
            Console.WriteLine(new string('-', sub) + Descricao);

            _lista.ForEach(m => m.ExibirMensagens(sub + 2));
        }

    }
}
