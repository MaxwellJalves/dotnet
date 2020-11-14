using System;
/**
@Maxwell.costa
@Estudo da linguagem C# - não levem em consideração a estrutura do código
Pois o objetivo é estudar e evoluindo com o estudo, acertos e erros da linguagem.

A Classe Pessoa não está seguindo o padrão da documentação porém é funcional já 
a Classe Curso está seguindo os padrões  disponibizado na documentação oficial.
 
Realizando um comparativo entre o Java o C# , embora os conceitos tenham sido os mais basicos possiveis
a quandidade de código digitada no java é bem maior que a do C#.


https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/get

*/
namespace dotnet
{
    class Program
    {

        static void Main(string[] args)
        {
            //#Instanciando Classe Pessoa
            Console.WriteLine("##Begin     -------Instanciando Classe Pessoa");
            Pessoa p = new Pessoa(101010, "Maxwell Costa", 30, "Desenvolvedor");
            Console.WriteLine($"Matricula : {p.getMatricula()}\n Nome : {p.getNome().ToUpper()} \n Idade:{p.getIdade()} \n Profissão {p.getProfissao().ToUpperInvariant()}");
            Console.WriteLine("## End - Finalizando Bloco de apresentação.");

            //Curso
            Curso c = new Curso();

            //#Declare

            String aviso = "Aguarde enquanto carregamos as informações";

            Console.WriteLine("#Begin" + "\n");

            Console.WriteLine("Informe seu nome");
            p.setNome(Console.ReadLine().ToUpper());

            Console.WriteLine("informe o seu Curso");
            c.descricao = Console.ReadLine();

            Console.WriteLine("Informe o código da Matricula.");
            c.cd_aluno =Convert.ToInt32(Console.ReadLine());

            if(c.cd_aluno.Equals(p.getMatricula())){
                Console.WriteLine("Código de matricula vinculado a outro aluno");
                c.cd_aluno = p.getMatricula()+1;
                Console.WriteLine($"Não se preocupe ! \n  Verificamos que você é um novo(a) Aluno(a) \n Seu código de matricula é : Nº {c.cd_aluno}");
            }

            if (p.getNome().ToUpper() != "Jose".ToUpper())
            {
                Console.WriteLine($"Seja Bem vindo(a) ! \n {p.getNome().ToUpper()} \n Curso : {c.descricao.ToUpper()}");
            }
            else
            {
                ExibirMensagemCobrança(p.getNome().ToUpper());
                string status = "";
                do
                {
                    Console.WriteLine("Deseja Quitar a divida e realizar sua matricula ? \n Pressione 1 para Sim ou 2 para Não");
                    if ((status = Console.ReadLine()) == "1")
                    {
                        status = "S";
                    }
                    else
                    {
                        Console.WriteLine("Tem certeza ?");
                        if ((status = Console.ReadLine()) == "1")
                        {
                            status = "S";
                            //exibe a mensagem e saiu da aplicação
                        }
                    }
                } while (status != "S");

                Exibir_Mensagem(aviso);

            }

            Console.WriteLine("#End" + "\n");

        }
        private static void Exibir_Mensagem(string a)
        {
            Console.WriteLine("\n Seja bem vindo! " + "\n");
            Console.WriteLine(a.ToUpper());
        }

        private static void ExibirMensagemCobrança(string n)
        {
            Console.WriteLine($"Bom dia! Srº.  {n.ToUpper()} \n Verificamos em nosso sistema que o Senhor já foi nosso aluno Existe uma pendencia financeira no valor de R$ 100,00, deseja efetuar o pagamento?");

        }
    }
}
