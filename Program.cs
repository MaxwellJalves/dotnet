using System;

namespace dotnet
{
    class Program
    {
   
        static void Main(string[] args)
        {
            //#Declare
            string nome;
            String aviso = "Aguarde enquanto carregamos as informações";

            Console.WriteLine("#Begin" + "\n");

            Console.WriteLine("Informe seu nome");
            nome = Console.ReadLine().ToUpper();

            if (nome != "Jose da Silva".ToUpper())
            {
                Console.WriteLine($"Seja Bem vindo !  {nome}");
            }
            else
            {
                ExibirMensagemCobrança(nome);
                string status = "";
                if (status == "S")
                {

                }
                else
                {
                    Exibir_Mensagem(aviso);
                }
            }

            Console.WriteLine("#End" + "\n");

        }
        private static void Exibir_Mensagem(string a)
        {
            Console.WriteLine("Seja bem vindo! " + "\n");
            Console.WriteLine(a.ToUpper());
        }

        private static void ExibirMensagemCobrança(string n){
            Console.WriteLine($"Bom dia! Srº.  {n.ToUpper()} \n Verificamos em nosso sistema que o Senhor já foi nosso aluno Existe uma pendencia financeira no valor de R$ 100,00, deseja efetuar o pagamento?");
                
        }
    }
}
