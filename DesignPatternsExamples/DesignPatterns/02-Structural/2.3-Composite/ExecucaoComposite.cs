using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns._02_Structural._2._3_Composite
{
    public class ExecucaoComposite
    {
        public static void Executar()
        {
            var validacaoCadastro = new Mensagem("O cadastro não foi realizado!");

            var usarioFormErro = new Mensagem("O usuário informou um nome inválido");

            //form
            var tamanhoNomeForm = new InputFormMessage("O nome precisa possuir mais de 2 caracteres");
            var nomeVazioForm = new InputFormMessage("O nome não pode possuir números");

            usarioFormErro.AdicionarFilha(tamanhoNomeForm);
            usarioFormErro.AdicionarFilha(nomeVazioForm);

            validacaoCadastro.AdicionarFilha(usarioFormErro);

            //domain
            var domainUsuarioErro = new Mensagem("Problemas ao processar o cadastro do usuário");

            var cpfUsuarioDomain = new DomainMessage("O CPF informado está em uso!");
            var emailUsuarioDomain = new DomainMessage("O Email informado está em uso!");

            domainUsuarioErro.AdicionarFilha(cpfUsuarioDomain);
            domainUsuarioErro.AdicionarFilha(emailUsuarioDomain);

            validacaoCadastro.AdicionarFilha(domainUsuarioErro);

            validacaoCadastro.ExibirMensagens(2);
        }
    }
}
