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

            if (nome != "Jose".ToUpper())
            {
                Console.WriteLine($"Seja Bem vindo !  {nome}");
            }
            else
            {
                ExibirMensagemCobrança(nome);
                string status = "";
                    do{
                        Console.WriteLine("Deseja Quitar a divida e realizar sua matricula ? \n Pressione 1 para Sim ou 2 para Não");
                        if((status =Console.ReadLine()) == "1"){
                            status = "S";
                        }else{
                            Console.WriteLine("Tem certeza ?");
                            if((status = Console.ReadLine()) == "1"){
                                status = "S";
                                //exibe a mensagem e saiu da aplicação
                            }
                        }
                    }while(status != "S");
               
                    Exibir_Mensagem(aviso);
                
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
